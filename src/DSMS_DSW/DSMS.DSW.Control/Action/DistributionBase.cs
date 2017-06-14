using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.OPC;
using System.Threading;

namespace DSMS.DSW.Control.Action
{
    public class DistributionBase
    {

        private  int _status;//0 未执行 1 开始 2、完成.
        ParamClass PC;
        ParamClass.ParamEnum PE;


        public event EventHandler Competed_Event; //完成事件
        protected event EventHandler Start_Event; //完成事件



        /// <summary>
        /// 定型专用
        /// </summary>
        public  void FormulaStop()
        {
            if (_status == 1 )
            { 
                PC.OpcSyncWrite(PE, "2"); //异常停止写入
                Golbal.DSStep = 4;
            }
        }


        public void FormulaStopTest()
        {
            if (_status == 1)
            {
                PC.OpcSyncWrite(PE, "2"); //异常停止写入
            }
        }


        System.Timers.Timer tTimer;
        public DistributionBase()
        {
            tTimer = new System.Timers.Timer(200);
            tTimer.Elapsed += WaitComplete;
        }
   
    
        public void KepWriteStatus( ParamClass pc ,ParamClass.ParamEnum  pe)
        {
            PC = pc;
            PE = pe ;
            Start_Event(this, null);
            _status = 0;
            tTimer.Start();
        }

        //等待配送完成
        public void WaitComplete(object sender,EventArgs e)
        {
            tTimer.Stop();
             string Value = PC.OpcSyncRead(PE);
              if(_status == 0)
              {
                  if (Value == "0" || Value == "2")
                  { 
                      PC.OpcSyncWrite(PE, "1"); //重新写入
                  }
                  else{
                  _status = 1; // 开始
                  }
              }

              if(_status==1){

                   if (Value == "2") {
                       _status = 2; // 完成
                      //PC.OpcSyncWrite(PE, "0"); //置零

                   }
              }
       
              if (_status == 2)
              {
                  tTimer.Stop();
                  Competed_Event(this, null);//执行完成动作
              }
              else {
                  tTimer.Start();
              }
        }
    }
}
