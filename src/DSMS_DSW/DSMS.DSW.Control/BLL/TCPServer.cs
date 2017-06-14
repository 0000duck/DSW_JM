using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Data;
using System.Threading.Tasks;
using DSMS.DSW.Control.Class;
using DSMS.DSW.DAL;
using DSMS.DSW.Model;

namespace DSMS.DSW.Control.Action.BLL
{
    public partial class TCPServer 
    {
        #region
        TCPClass tcpclass = null;
      
        DS_DeviceDAL deviceDAL = new DS_DeviceDAL();
        List<DS_DeviceModel> deviceList;
        List<View_DeviceInfoModel> potList;
        public  event EventHandler WashingFormulaEnd; //完成事件
        #endregion
        public void Excute()
        {
            DS_PotDAL potDAL = new DS_PotDAL();
            potList = potDAL.GetPotListByType(3);//获取所有缸信息
            DS_DeviceDAL deviceDAL = new DS_DeviceDAL();
            deviceList = deviceDAL.GetList(3);
            tcpclass = new TCPClass();
            tcpclass.Receive_Event += Receive_Event;
            tcpclass.Error_Event += Error_Event;
 
            Task.Factory.StartNew(() => //线程执行任务
            {
                while (true)
                {
                    if (Golbal.CurrentFormulaModel != null)
                    {
                        tcpclass.SendString(IPAddress.Parse(Golbal.CurrentFormulaModel.ClientIP), GetActionInfo());
                    }
                    Thread.Sleep(1000);
                }
            });

            Task.Factory.StartNew(() => //线程执行任务
            {
                while (true)
                {
                    foreach (DS_DeviceModel devicemodel in deviceList)
                    {
                        string washstr = WashingGetActionInfo(devicemodel.Id);
                        tcpclass.SendString(IPAddress.Parse(devicemodel.IP), washstr);
                        Thread.Sleep(1000);
                    }
                  
                }
            });
        }

        #region 接收数据
        private void Receive_Event(object sender, EventArgs e)
        {
            CReceive cReceive = (CReceive)sender;
            string[] ls = cReceive.ReceiveString.Split('|');
            if (ls.Length > 0)
            {
                if (ls[0] == "0")
                {
                    // ls[0]请求 ls[1]  机台编号  ls[2]  配方Id   ls[3] 请求量 ls[4] 缸号 
                    DistributionRequest(ls[1], ls[2], ls[3],ls[4], cReceive.RemoteIP);

                }

                else if (ls[0] == "1")
                {
                    //终止
                    // ls[0]请求 ls[1] 机缸编号  
                    lock (Golbal.MyQueueList)
                    {
                        try
                        {
                            Golbal.MyQueueList.RemoveAll(s => s.DeviceCode == ls[1]);
                            tcpclass.SendString(cReceive.RemoteIP, "终止成功!");
                        }
                        catch
                        {
                            tcpclass.SendString(cReceive.RemoteIP, "终止失败!");
                        }
                    }

                }
                else if (ls[0] == "2")
                {
                    // ls[0]请求 ls[1]  机台编号 ls[2]  机缸编号  ls[3] 皂洗剂  ls[4] 水   
                    WashingRequest(ls[1], ls[2], ls[3],ls[4], cReceive.RemoteIP);
                }
                else if (ls[0] == "3")
                {
                    try
                    {

                        if (Golbal.CurrentWashingaModel != null && Golbal.WashingWaterStep > 0)
                        {
                            if (Golbal.CurrentWashingaModel.DeviceCode == ls[1])
                            {
                                //停止配送
                                WashingFormulaEnd(null, null);
                            }
                        }
                        else
                        {
                            Golbal.MyWashingList.RemoveAll(s => s.DeviceCode == ls[1]);

                        }
                        tcpclass.SendString(cReceive.RemoteIP, "终止成功!");
                    }
                    catch
                    {

                        tcpclass.SendString(cReceive.RemoteIP, "终止失败!");
                    }
                
                }
            }

        }


         private void DistributionRequest(string deviceCode,string id, string cylinderNum,string potcode, IPAddress remoteIP)
        {
            Guid gid;
            if (Guid.TryParse(id, out gid))
            {
                   View_FormulaInfoModel model =Golbal.MyQueueList.FirstOrDefault(s => s.DeviceCode == deviceCode);
                    if (model!=null)
                    {
                        tcpclass.SendString(remoteIP, "请稍后再试!");
                    }
                    else
                    {
                        // ls[0]请求 ls[1]  机缸编号  ls[2]  配方Id   ls[3] 请求量  
                        DSW_FormulaDetailDAL formulaDetailDAL = new DSW_FormulaDetailDAL();
                        View_FormulaInfoModel formulaDetailModel = formulaDetailDAL.GetModelById(gid);
                        if (formulaDetailModel != null)
                        {
                            formulaDetailModel.ClientIP = remoteIP.ToString();
                            formulaDetailModel.CylinderNum = int.Parse(cylinderNum);

                            formulaDetailModel.list = formulaDetailDAL.GetFormulaDetailInfoList(formulaDetailModel.BarCode);
                            if (formulaDetailModel.list == null)
                            {
                                tcpclass.SendString(remoteIP, "请求失败!");
                            }
                            else
                            {
                                formulaDetailModel.PotCode = potcode;
                                formulaDetailModel.CompleteCylinderNum = 0;//初始完成缸数
                                Golbal.MyQueueList.Add(formulaDetailModel);
                                tcpclass.SendString(remoteIP, "请求成功!");
                            }
                        }
                        else
                        {
                            tcpclass.SendString(remoteIP, "配方无效!");
                        }
                    }
            }
           else{
                          tcpclass.SendString(remoteIP, "请求失败!");  
            }
       }


        /// <summary>
        /// 皂洗剂请求
        /// </summary>
         private void WashingRequest(string deviceCode,string potCode ,string materialquantity, string cabientwaterquantity, IPAddress remoteIP)
         {

             decimal ovalue1, ovalue2;

             if (Golbal.MyWashingList.FindAll(s => s.DeviceCode == deviceCode).Count() > 0)
             {
                 tcpclass.SendString(remoteIP, "请稍后再试!");
                 return;
             }

             if (decimal.TryParse(materialquantity, out ovalue1) && decimal.TryParse(cabientwaterquantity, out ovalue2))
             {

                 DS_DeviceModel devicemodel = deviceDAL.GetDeviceByCode(deviceCode);
                 if (devicemodel == null)
                 {

                     tcpclass.SendString(remoteIP, "请求失败!");
                 }
                 else
                 {

                     if (ovalue1 + ovalue2 > devicemodel.StandardQuantity)
                     {

                         tcpclass.SendString(remoteIP, "总量不能超过" + devicemodel.StandardQuantity.Value.ToString("0.00L"));

                     }
                     else if (ovalue1 + ovalue2 == 0)
                     {
                         tcpclass.SendString(remoteIP, "请修改请求量");

                     }
                     else
                     {
                         View_WashingModel washingmodel = new View_WashingModel();
                         washingmodel.Id = Guid.NewGuid();
                         washingmodel.BarCode = Golbal.ConvertDateTimeInt(DateTime.Now).ToString();
                         washingmodel.MaterialQuantity = ovalue1;
                         washingmodel.CabientWaterQuantity = ovalue2;
                         washingmodel.DeviceId = devicemodel.Id;
                         washingmodel.DeviceCode = devicemodel.Code;
                         washingmodel.DeviceName = devicemodel.Name;
                         washingmodel.ClientIP = remoteIP.ToString();
                         washingmodel.Devicetype = devicemodel.Type;
                         washingmodel.PotCode = potCode;
                         Golbal.MyWashingList.Add(washingmodel);
                         tcpclass.SendString(remoteIP, "请求成功");
                     }
                 }
             }


         }


        public void Error_Event(object sender, EventArgs e)
        {
            //MessageBox.ShowTip(sender.ToString());
        }
        #endregion

        #region 发送数据
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="str"></param>
      
        public string GetActionInfo()
        {
        StringBuilder strSql = new StringBuilder();
        strSql.AppendLine(Golbal.CurrentAction);
        strSql.AppendLine(Golbal.CurrentFormulaModel.ProductName);
        strSql.AppendLine(Golbal.CurrentFormulaModel.Quantity.ToString("0.00"));
        strSql.AppendLine(Golbal.ParamClass.配送总量实际);
        strSql.AppendLine(Golbal.CurrentFormulaModel.CylinderNum.ToString());
        strSql.AppendLine(Golbal.CurrentFormulaModel.CompleteCylinderNum.ToString());
        strSql.AppendLine(Golbal.CurrentFormulaModel.Customer);
        strSql.AppendLine(Golbal.CurrentFormulaModel.ProductSpecification);
        return strSql.ToString().Replace("\r\n", "|");

        }

        /// 水洗
        private string WashingGetActionInfo(Guid deviceId)
        {
            StringBuilder strbuilder = new StringBuilder();

            if (Golbal.CurrentWashingaModel != null && Golbal.CurrentWashingaModel.DeviceId == deviceId)
            {
                strbuilder.AppendLine(Golbal.WashingCurrentAction);
                strbuilder.AppendLine(Golbal.ParamClass.水洗助剂配送实际 + "|" + Golbal.ParamClass.水洗机台配送总量);
            }
            else
            {
                if (Golbal.MyWashingList.FindAll(s => s.DeviceId == deviceId).Count() > 0)
                {
                    strbuilder.AppendLine("已请求等待配送");  //已请求过
                }
                else
                {
                    strbuilder.AppendLine("等待机台请求");  //未请求过
                }

                strbuilder.AppendLine("0" + "|" + "0");
            }

            foreach (View_DeviceInfoModel potmodel in potList.FindAll(s => s.DeviceId == deviceId))
            {

                if (Golbal.ParamClass != null && Golbal.ParamClass.IsAlarming(potmodel.PotCode))
                {
                    strbuilder.AppendLine("1");//空缸
                }
                else
                {
                    strbuilder.AppendLine("0");//非空
                }
            }
            return strbuilder.ToString().Replace("\r\n", "|");
        }
        #endregion
    }
}
