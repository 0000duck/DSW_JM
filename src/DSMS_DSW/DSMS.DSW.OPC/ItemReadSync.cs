using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OPCAutomation;
using System.Data;
using System.Diagnostics;
using DSMS.DSW.DAL;
using DSMS.DSW.Model;

namespace DSMS.DSW.OPC
{
   public class ItemReadSync
    {
   
        #region 声明采集
        OPCServer objServer;
        OPCGroups objGroups;
        OPCGroup objGroup;
        OPCItems objItems;
        OPCAutomation.OPCItem[] opcItem;
        ParamClass paramClass;
        System.Timers.Timer tTimer;
        #endregion
    

        #region 连接采集
        public ItemReadSync(ParamClass PC)
        {
            CreateGroup();
            opcItem = new OPCAutomation.OPCItem[PC.ParamList.Count];
            objItems = objGroup.OPCItems;
            for (int i = 0; i < PC.ParamList.Count; i++)
            {
                opcItem[i] = objItems.AddItem(PC.ParamList[i].KepAddress, i);
            }

            paramClass = PC;

            tTimer = new System.Timers.Timer(100);
            tTimer.Elapsed += SyncRead;
            tTimer.Start();
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


        public void SyncRead(object sender, EventArgs e)
        {
            tTimer.Stop();
            string LabelName = string.Empty;
            try
            {
                object ItemValues; object Quantities; object TimeStamps;//同步读取临时变量 值 质量 时间戳

                for (int i = 0; i < paramClass.ParamList.Count; i++)
                {
                    opcItem[i].Read(1, out ItemValues, out Quantities, out TimeStamps);
                    if (Quantities.ToString() == "192")
                    {
                        LabelName = paramClass.ParamList[i].LabelName;

                        Type type = paramClass.GetType(); //获取类型
                        System.Reflection.PropertyInfo propertyInfo = type.GetProperty(LabelName); //获取指定名称的属性
                        //int value_Old = (int)propertyInfo.GetValue(paramClass, null); //获取属性值
                        if (propertyInfo != null) propertyInfo.SetValue(paramClass, ItemValues.ToString(), null); //给对应属性赋值
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