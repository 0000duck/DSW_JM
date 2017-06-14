using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.OPC;
using System.Threading;

namespace DSMS.DSW.Control.Action
{
   public class WashingFormulaStatus
    {

       public event EventHandler Start_Event; //开始事件
       public event EventHandler End_Event; //结束事件
       //配方开始
       public  void FormulaStart(ParamClass pc )
       {
 
   
               pc.OpcSyncWrite(ParamClass.ParamEnum.水洗配方状态, "0");
               Thread.Sleep(100);

               if (pc.水洗配方状态 == "0")
               {
                   Start_Event(this,null);
               }
               else {

                   FormulaStart(pc);
               }
       }


       //配方结束
       public void FormulaEnd(ParamClass pc)
       {


           pc.OpcSyncWrite(ParamClass.ParamEnum.水洗配方状态, "1");
           Thread.Sleep(100);

           if (pc.水洗配方状态 == "1")
           {
               End_Event(this, null);
           }
           else
           {
               FormulaEnd(pc);
           }
       }


    }
}
