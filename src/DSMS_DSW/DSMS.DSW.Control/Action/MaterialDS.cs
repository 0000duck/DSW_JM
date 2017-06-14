using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.OPC;

namespace DSMS.DSW.Control.Action
{
   public class MaterialDS:DistributionBase
  {

       public MaterialDS()
       {
           base.Start_Event += start_Event;
       }
       public DsMaterial CurrentDsMaterial;

       //执行入口
       public void Excute(ParamClass pc, string potCode,  DsMaterial dsMaterial)
       {
           CurrentDsMaterial = dsMaterial;
           pc.FucMaterialDS(potCode, CurrentDsMaterial.MaterialCode, CurrentDsMaterial.MaterialQuantity);
           base.KepWriteStatus(pc, ParamClass.ParamEnum.助剂配送状态);
 
       }

       public void start_Event(object sender, EventArgs e)
       {
         if(Golbal.DSStep>0)
          Golbal.CurrentAction = "助剂配送:" + CurrentDsMaterial.MaterialName;
       }
    }
}
