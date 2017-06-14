using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OPCAutomation;
using System.Threading;

namespace OPCHelper
{
  public  class IsExistTag
    {
        #region 声明采集
        OPCServer objServer;

        OPCGroups objGroups;

        OPCGroup objGroup;

        OPCItems objItems;

      
        #endregion

        public IsExistTag()
        {
            CreateGroup();
        }
          


        public bool TagCheck(string tag)
       {
          try
          {
           
              OPCItem opcItme = objGroup.OPCItems.AddItem(tag, 0);//byte  
              Thread.Sleep(100);
              object ItemValues; object Qualities; object TimeStamps;//同步读的临时变量：值、质量、时间戳  
              opcItme.Read(1, out ItemValues, out Qualities, out TimeStamps);//同步读，第一 
              ConnDispose();
              return true;
          }
          catch
          {
              ConnDispose();
              return false;
          }

      }


        #region 创建组
        private void CreateGroup()
        {

            objServer = new OPCServer();
            //连接opc server
            objServer.Connect("kepware.kepserverex.v4", null);

            //(2)建立一个opc组集合
            objGroups = objServer.OPCGroups;
            //(3)建立一个opc组
            objGroup = objGroups.Add("Opc"); //Group组名字可有可无 
            //(4)添加opc标签
            objGroup.IsActive = true; //设置该组为活动状态，连接PLC时，设置为非活动状态也一样
            objGroup.IsSubscribed = false; //设置异步通知
        }
        #endregion



       public void ConnDispose()
       {
           //释放所有组资源
           objServer.OPCGroups.RemoveAll();
           //断开服务器
           objServer.Disconnect();
 
       }

    }
}
