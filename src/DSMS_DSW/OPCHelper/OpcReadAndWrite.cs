using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OPCAutomation;
using System.Data;
using DSMS.DSW.Model;



namespace OPCHelper
{
    public class OpcReadAndWrite : ItemReadSync
    {

        #region 声明采集
        OPCServer objServer;

        OPCGroups objGroups;

        OPCGroup objGroup;

        OPCItems objItems;


        OPCAutomation.OPCItem[] opcItem;
        Dictionary<string, OPCAutomation.OPCItem> myDcWrite = new Dictionary<string, OPCItem>();
        #endregion


        #region 连接采集
        public OpcReadAndWrite(List<DSW_ParamTableModel> list)
            : base(list)
       {
          
           CreateGroup();
           opcItem = new OPCAutomation.OPCItem[ModelList.Count];
           objItems = objGroup.OPCItems;
           myDcWrite.Clear();
           for (int i = 0; i < ModelList.Count; i++)
           {
               opcItem[i] = objItems.AddItem(ModelList[i].KepAddress, i);
               myDcWrite.Add(ModelList[i].KepAddress, opcItem[i]);
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
            objGroup = objGroups.Add("OpcReadAndWrite"); //Group组名字可有可无 
            //(4)添加opc标签
            objGroup.IsActive = true; //设置该组为活动状态，连接PLC时，设置为非活动状态也一样
            objGroup.IsSubscribed = false; //设置异步通知
        }
        #endregion


        public void SyncWrite(string address, string value)
        {
            myDcWrite[address].Write((object)value);
        }


        public  void ConnDispose()
        {
            if (objItems != null)
                if (objItems.Count > 0)
                {

                    //释放所有组资源
                    objServer.OPCGroups.RemoveAll();
                    //断开服务器
                    objServer.Disconnect();
                }

            base.Dispose();
        }



    }
}