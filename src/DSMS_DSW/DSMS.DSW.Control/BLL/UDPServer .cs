using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using DSMS.DSW.DAL;
using DSMS.DSW.Model;
using System.Collections;

namespace DSMS.DSW.Control.BLL
{
    public class UDPServer
    {


       // List<View_DeviceInfoModel> potList;
       // List<DS_DeviceModel> deviceList;
       // public void Excute()
       // {
       //     InitUdp();
       //     DS_PotDAL potDAL = new DS_PotDAL();
       //     potList = potDAL.GetPotListByType(3);//获取所有缸信息
       //     DS_DeviceDAL deviceDAL = new DS_DeviceDAL();
       //     deviceList = deviceDAL.GetList(3);

       //     System.Threading.Thread threadListen = new System.Threading.Thread(new ThreadStart(ListeningServer));
       //     threadListen.Start();
       //     System.Threading.Thread threadSend = new System.Threading.Thread(new ThreadStart(SendData));
       //     threadSend.Start();
       // }

       // private void InitUdp()
       // {
       //     try
       //     {
       //         if (udpClient == null)
       //             udpClient = new UdpClient(clientPort);
       //         if (udpReceiver == null)
       //         {
       //             udpReceiver = new UdpClient(serverPort, AddressFamily.InterNetwork);
       //         }
       //     }
       //     catch { }
       // }


       // #region 发送数据
       // UdpClient udpClient = null;
       // int clientPort = 10001;
       // /// <summary>
       // /// 发送数据
       // /// </summary>
       // /// <param name="str"></param>
       // private void SendData()
       // {
       //     while (true)
       //     {

       //         if (Golbal.CurrentFormulaModel != null)
       //         {
       //             string clientIP = Golbal.CurrentFormulaModel.ClientIP;
       //             string str = GetActionInfo();
       //             if (!string.IsNullOrEmpty(str))
       //             {
       //                 byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
       //                 try
       //                 {
       //                     udpClient.Send(bytes, bytes.Length, clientIP, clientPort);
       //                 }
       //                 catch
       //                 {
       //                 }
       //             }
       //         }

       //         foreach (DS_DeviceModel devicemodel in deviceList)
       //         {
       //                string washstr = WashingGetActionInfo(devicemodel.Id);
       //                byte[] bytes = System.Text.Encoding.Default.GetBytes(washstr);
       //                 try
       //                 {
       //                     udpClient.Send(bytes, bytes.Length, devicemodel.IP, clientPort);
       //                 }
       //                 catch
       //                 {
       //                 }
       //         }


       //         Thread.Sleep(1000);
       //     }
       // }

       // /// <summary>
       // /// 发送数据
       // /// </summary>
       // /// <param name="str"></param>
       // private void SendDataByOne(string str, string ipaddress)
       // {
       //     byte[] bytes = System.Text.Encoding.Default.GetBytes(str);

       //     try
       //     {
       //         udpClient.Send(bytes, bytes.Length, ipaddress, clientPort);
       //     }
       //     catch
       //     {
       //     }

       // }
       // #endregion
       // #region 接收数据
       // UdpClient udpReceiver = null;
       // int serverPort = 50000;
       // /// <summary>
       // /// 接收数据
       // /// </summary>
       // /// <param name="str"></param>
       // private void ListeningServer()
       // {
       //     while (true)
       //     {
       //         if (udpReceiver != null)
       //         {
       //             IPEndPoint remoteHost = null;
       //             try
       //             {
       //                 byte[] data = udpReceiver.Receive(ref remoteHost);

       //                 string[] ls = System.Text.Encoding.Default.GetString(data).Split('|');
       //                 string barCode = ls[1];
       //                 switch (ls[0])
       //                 {
       //                     case "0": SendDataByOne(RequestQueuesAdd(ls[1],ls[2],remoteHost.Address.ToString()), remoteHost.Address.ToString()); break;//定型机请求
       //                     case "1": SendDataByOne(ChanelBarCode(ls[1]), remoteHost.Address.ToString()); break;//定型机取消
       //                     case "2": SendDataByOne(RequestListAdd(ls[1], ls[2], remoteHost.Address.ToString()), remoteHost.Address.ToString()); break;//水洗机请求
       //                     case "3": SendDataByOne(WashingChanel(ls[1]),remoteHost.Address.ToString()); break;//水洗机取消
       //                 }
       //             }
       //             catch
       //             {

       //             }
       //         }
       //         else
       //         {
       //             udpReceiver = new UdpClient(serverPort, AddressFamily.InterNetwork);
       //         }
       //         Thread.Sleep(500);
       //     }
       // }

       // #endregion


       // public string GetActionInfo()
       // {

  
       // StringBuilder strSql = new StringBuilder();
       // strSql.AppendLine(Golbal.CurrentAction);
       // strSql.AppendLine(Golbal.CurrentFormulaModel.ProductName);
       // strSql.AppendLine(Golbal.CurrentFormulaModel.StandardQuantity.ToString("0.00"));
       // strSql.AppendLine(Golbal.ParamClass.配送总量实际);
       // strSql.AppendLine(Golbal.CurrentFormulaModel.CylinderNum.ToString());
       // strSql.AppendLine(Golbal.CurrentFormulaModel.CompleteCylinderNum.ToString());
       // strSql.AppendLine(Golbal.CurrentFormulaModel.Customer);
       // strSql.AppendLine(Golbal.CurrentFormulaModel.ProductSpecification);
       // return strSql.ToString().Replace("\r\n", "|");
             
       // }


       // public string RequestQueuesAdd(string id, string cylinderNum, string ip)
       // {
       //     Guid gid;

       //     if (!Guid.TryParse(id, out gid))
       //     {
       //         return "请求失败";
       //     }

       //     DSW_FormulaDetailDAL formulaDetailDAL = new DSW_FormulaDetailDAL();
       //     View_FormulaInfoModel formulaDetailModel = formulaDetailDAL.GetModelById(gid);
       //     formulaDetailModel.CylinderNum = int.Parse(cylinderNum);
       //     if (formulaDetailModel != null)
       //     {
       //         formulaDetailModel.ClientIP = ip;
       //         if (formulaDetailModel.LatestDate <DateTime.Now)
       //         {
       //             return "条码过期";
       //         }

       //         formulaDetailModel.list = formulaDetailDAL.GetFormulaDetailInfoList(formulaDetailModel.BarCode);
       //         if (formulaDetailModel.list == null)
       //         {
       //             return "请求失败";
       //         }

       //         if (Golbal.MyQueue.Select(s => s.DeviceId = formulaDetailModel.DeviceId).Count() > 0)
       //         {
       //             return "请稍后再试";
       //         }
       //         else
       //         {
       //             formulaDetailModel.CompleteCylinderNum = 0;//初始完成缸数
       //             Golbal.MyQueue.Enqueue(formulaDetailModel);
 
       //             return "请求成功";
       //         }
       //     }
       //     else
       //     {
       //         return "条码无效";
       //     }
       // }



       // private string ChanelBarCode(string deviceid)
       // {

       //     try
       //     {
       //         Guid gid;

       //         if (!Guid.TryParse(deviceid, out gid))
       //         {
       //             return "终止失败";
       //         }

       //         lock (Golbal.MyQueue)
       //         {
       //             for (int i = 0; i < Golbal.MyQueue.Count; i++)
       //             {
       //                 View_FormulaInfoModel model = Golbal.MyQueue.ToList().Find(s => s.DeviceId == gid);

       //                 if (model != null)
       //                 {
       //                     model.CompleteCylinderNum = model.CylinderNum;
       //                 }
       //             }
       //         }
       //         return "终止成功";
       //     }
       //     catch
       //     {

       //         return "终止失败";
       //     }
       // }



       // /// 水洗
       // private string  WashingGetActionInfo(Guid deviceId)
       // {
       //     StringBuilder strbuilder = new StringBuilder();



       //     if (Golbal.CurrentWashingaModel!=null&& Golbal.CurrentWashingaModel.DeviceId == deviceId)
       //     {
       //         strbuilder.AppendLine(Golbal.WashingCurrentAction);
       //         strbuilder.AppendLine(Golbal.ParamClass.水洗助剂配送实际 + "L" + "  " + Golbal.ParamClass.水洗机台放水实际 + "L");
       //     }
       //     else {
       //         if (Golbal.MyWashingList.FindAll(s => s.DeviceId == deviceId).Count() > 0)
       //         {
       //             strbuilder.AppendLine("已请求等待配送");  //已请求过
       //         }
       //         else {
       //             strbuilder.AppendLine("等待机台请求");  //未请求过
       //         }

       //         strbuilder.AppendLine("0L" + "  " + "0L");
       //     }

       //     foreach (View_DeviceInfoModel potmodel in potList.FindAll(s => s.DeviceId == deviceId))
       //     {

       //         if (Golbal.ParamClass!=null&&Golbal.ParamClass.IsAlarming(potmodel.PotCode))
       //         {
       //             strbuilder.AppendLine("1");//空缸
       //         }
       //         else {
       //             strbuilder.AppendLine("0");//非空
       //         }
       //     }
       //     return strbuilder.ToString().Replace("\r\n", "|");
            
       // }
 
 

       // public string RequestListAdd(string materialquantity, string cabientwaterquantity, string clientip)
       // {

       //     decimal ovalue1, ovalue2;
             

       //     if (Golbal.MyWashingList.FindAll(s => s.ClientIP == clientip).Count() > 0)
       //     {
       //         return "请稍后再试";
       //     }
            

       //     if (decimal.TryParse(materialquantity, out ovalue1) && decimal.TryParse(cabientwaterquantity, out ovalue2))
       //     {
       //         DS_DeviceDAL deviceDAL = new DS_DeviceDAL();
       //         DS_DeviceModel devicemodel = deviceDAL.GetDeviceByIP(clientip);
       //         if (devicemodel == null)
       //         {
       //             return "请求失败";
       //         }
       //         else
       //         {

       //             if (ovalue1 + ovalue2 > devicemodel.StandardQuantity)
       //             {

       //                 return "总量不能超过" + devicemodel.StandardQuantity.Value.ToString("0.00L");
       //             }
       //             else if (ovalue1 + ovalue2 == 0)
       //             {
       //                 return "请修改请求量";
       //             }
       //             else
       //             {
       //                 View_WashingModel washingmodel = new View_WashingModel();
       //                 washingmodel.Id = Guid.NewGuid();
       //                 washingmodel.BarCode = Golbal.ConvertDateTimeInt(DateTime.Now).ToString();
       //                 washingmodel.MaterialQuantity = ovalue1;
       //                 washingmodel.CabientWaterQuantity = ovalue2;
       //                 washingmodel.DeviceId = devicemodel.Id;
       //                 washingmodel.DeviceCode = devicemodel.Code;
       //                 washingmodel.DeviceName = devicemodel.Name;
       //                 washingmodel.ClientIP = clientip;
       //                 washingmodel.Devicetype = devicemodel.Type;
       //                 Golbal.MyWashingList.Add(washingmodel);
       //                 return "请求成功";
       //             }
       //         }
       //     }
       //     else {

       //         return "请求成功"; //接收到的值不是有效地数字
       //     }

       // }


       //public  event EventHandler WashingFormulaEnd; //完成事件

       // private string WashingChanel(string deviceCode)
       // {

       //     try
       //     {


       //         if (Golbal.CurrentWashingaModel != null && Golbal.WashingWaterStep>0)
       //         {
       //             if (Golbal.CurrentWashingaModel.DeviceCode == deviceCode)
       //             {
       //                 //停止配送
       //                 WashingFormulaEnd(null, null);
                       
       //             }
       //         }
       //         else {
       //             Golbal.MyWashingList.RemoveAll(s => s.DeviceCode == deviceCode);
                    
       //         }
       //         return "终止成功";
       //     }
       //     catch
       //     {

       //         return "终止失败";
       //     }
       // }

    }
}
