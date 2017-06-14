using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.OPC;

namespace DSMS.DSW.Control.Action
{
    public class WashingCabinetWaterDS : DistributionBase
    {




        public WashingCabinetWaterDS()
        {
            base.Start_Event += start_Event;
            tTimer = new System.Timers.Timer(500);
            tTimer.Elapsed += tTimer_Elapsed;

        }
        System.Timers.Timer tTimer;
        public DsMaterial CurrentDsMaterial;
        public EventHandler PercentFinishEvent;
        bool IsPercent = false;

        decimal TargetQuantity = 0;
        //执行入口
        public void Excute(ParamClass pc, string potCode, decimal targetQuantity)
        {

            CurrentDsMaterial = new DsMaterial();
            CurrentDsMaterial.MaterialId = Golbal.WaterModel.Id.ToString();
            CurrentDsMaterial.MaterialCode = Golbal.WaterModel.Code;
            CurrentDsMaterial.MaterialName = Golbal.WaterModel.Name;
            CurrentDsMaterial.MaterialQuantity = targetQuantity;
            CurrentDsMaterial.Unit = Golbal.WaterModel.Unit;
            CurrentDsMaterial.Price = Golbal.WaterModel.Price.Value;
            pc.FucWashingWaterDS(potCode, targetQuantity);
            base.KepWriteStatus(pc, ParamClass.ParamEnum.水洗机台放水状态);

            TargetQuantity = targetQuantity;
            IsPercent = false;
            tTimer.Start();

        }


        private void tTimer_Elapsed(object sender, EventArgs e)
        {
            tTimer.Stop();
            if (!IsPercent && Golbal.WashingWaterStep > 0)
            {
                if (decimal.Parse(Golbal.ParamClass.水洗机台放水实际) > TargetQuantity/10)
                {
                    IsPercent = true;
                    PercentFinishEvent(null, null);
                }
            }
          tTimer.Start();
        }


        //配送开始
        public void start_Event(object sender, EventArgs e)
        {
            Golbal.WashingCurrentAction = "机台放水:" + CurrentDsMaterial.MaterialQuantity.ToString("0.00");
        }
    }
}

