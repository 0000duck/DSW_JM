using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.OPC;

namespace DSMS.DSW.Control.Action
{
   public class WashingMaterialDS:DistributionBase
  {

       public WashingMaterialDS()
       {
           base.Start_Event += start_Event;
       }
       public DsMaterial CurrentDsMaterial;

       //执行入口
       public void Excute(ParamClass pc, string potCode,  DsMaterial dsMaterial)
       {
           CurrentDsMaterial = dsMaterial;
           pc.FucWashingMaterialDS(potCode, CurrentDsMaterial.MaterialQuantity);
           base.KepWriteStatus(pc, ParamClass.ParamEnum.水洗助剂配送状态);
 
       }

       public void start_Event(object sender, EventArgs e)
       {
 
          Golbal.WashingCurrentAction = "助剂配送:" + CurrentDsMaterial.MaterialName;
       }
    }
}
