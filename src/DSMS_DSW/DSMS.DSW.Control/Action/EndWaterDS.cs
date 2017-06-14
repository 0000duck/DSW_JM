using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.OPC;

namespace DSMS.DSW.Control.Action
{
  public  class EndWaterDS:DistributionBase
  {
       public EndWaterDS()
       {
           base.Start_Event += start_Event;
       }
       public DsMaterial CurrentDsMaterial;
       //执行入口
       public void Excute(ParamClass pc,string potCode,string matCode ,decimal targetQuantity)
       {
           CurrentDsMaterial = new DsMaterial();
           CurrentDsMaterial.MaterialId = Golbal.WaterModel.Id.ToString();
           CurrentDsMaterial.MaterialCode = Golbal.WaterModel.Code;
           CurrentDsMaterial.MaterialName = Golbal.WaterModel.Name;
           CurrentDsMaterial.MaterialQuantity = targetQuantity;
           CurrentDsMaterial.Unit = Golbal.WaterModel.Unit;
           CurrentDsMaterial.Price = Golbal.WaterModel.Price.Value;
           pc.FucEndWater(potCode, matCode, targetQuantity);

           base.KepWriteStatus(pc, ParamClass.ParamEnum.助剂配送状态);

       }


       public void start_Event(object sender, EventArgs e)
       {
         Golbal.CurrentAction = "末端排放";
      
       }

    }
}
