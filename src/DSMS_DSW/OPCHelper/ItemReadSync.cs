using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OPCAutomation;
using System.Data;
using DSMS.DSW.Model;
 

namespace OPCHelper
{
   public class ItemReadSync
    {
   
        #region 声明采集
        OPCServer objServer;

        OPCGroups objGroups;

        OPCGroup objGroup;

        OPCItems objItems;

        OPCAutomation.OPCItem[] opcItem;
         
        string Address = string.Empty;
        System.Timers.Timer tTimer;
        XmlHelper xmlHelper=new XmlHelper();
        public  Dictionary<string, string> myDcValue = new Dictionary<string, string>();
        protected List<DSW_ParamTableModel> ModelList;
        #endregion
    

        #region 连接采集
        public ItemReadSync(List<DSW_ParamTableModel> list)
        {
            ModelList = list;

            if (ModelList.Count > 0)
            {
                 
                CreateGroup();
                opcItem = new OPCAutomation.OPCItem[ModelList.Count];
                objItems = objGroup.OPCItems;
                myDcValue.Clear();
                for (int i = 0; i < ModelList.Count; i++)
                {
                    opcItem[i] = objItems.AddItem(ModelList[i].KepAddress, i);

                    myDcValue.Add(ModelList[i].KepAddress, "");
                }
                tTimer = new System.Timers.Timer(100);
                tTimer.Elapsed += SyncRead;
                tTimer.Start();
            }
        }
        #endregion

        #region 创建组
        private void CreateGroup()
        {

            objServer = new OPCServer();
            //连接opc server
            objServer.Connect("kepware.kepserverex.v4", null);

            //(2)建立一个opc组集合
            objGroups = objServer.OPCGroups;
            //(3)建立一个opc组
            objGroup = objGroups.Add("ItemReadSync"); //Group组名字可有可无 
            //(4)添加opc标签
            objGroup.IsActive = true; //设置该组为活动状态，连接PLC时，设置为非活动状态也一样
            objGroup.IsSubscribed = false; //设置异步通知
            objGroup.UpdateRate = 10;
        }
        #endregion


        public void SyncRead( object sender ,EventArgs e)
        {
            tTimer.Stop();
        
            try
            {
                object ItemValues; object Quantities; object TimeStamps;//同步读取临时变量 值 质量 时间戳

                for (int i = 0; i < ModelList.Count; i++)
                {
                    opcItem[i].Read(1, out ItemValues, out Quantities, out TimeStamps);
                   
                    if (Quantities.ToString() == "192")
                    {
                        Address = ModelList[i].KepAddress;
                        myDcValue[Address] = ItemValues.ToString();
                         
                    }
                }
          
            }
            catch (Exception ex)
            {
              
                tTimer.Start();
            }
            tTimer.Start();
        }


    

        public void Dispose()
        {
            if (objItems != null)
                if (objItems.Count > 0)
                {

                    //释放所有组资源
                    objServer.OPCGroups.RemoveAll();
                    //断开服务器
                    objServer.Disconnect();
                }
        }
    }
}