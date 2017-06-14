using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DSMS.DSW.Control.Action
{
    public partial class ComSodaDistribution : Component
    {
        public ComSodaDistribution()
        {
            InitializeComponent();
            tTimer = new System.Timers.Timer(100);
            tTimer.Elapsed += Distribution;
        }

        public ComSodaDistribution(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        System.Timers.Timer tTimer;
        public int Status = 0;  //   0等待  1 开始  3 完成 
        public string RecordStr;
        public decimal ReturnSoda=0;
        /// <summary>
        /// 执行入口
        /// </summary>
        public void Excute(string potCode, decimal quantity)
        {
            Status = 1; //开始
            FrmDefault.ParamClass.FucSodaDS(potCode, quantity);
            ReturnSoda = quantity;
            FrmMain.CurrentAction = "回收碱";
            Thread.Sleep(500);
            if (FrmDefault.ParamClass.回收碱配送状态 == "1")
            {
                tTimer.Start();
            }
            else
            {
                Excute(potCode,quantity);
            }
        }
        /// <summary>
        // / 配送
        /// </summary>
        private void Distribution(object sender, EventArgs e)
        {
            tTimer.Stop();
                if (Status == 1 && FrmDefault.ParamClass.回收碱配送状态 == "2")
                {
                    RecordStr = "助剂配送|回收碱|" + FrmDefault.ParamClass.回收碱实际 + "|" + DateTime.Now.ToString("HH:mm:ss") + "|1";
                    FrmDefault.ParamClass.FucSodaDSSetStatus(0);
                    Status = 2;
                    Thread.Sleep(500);
                }
                else
                {
                    tTimer.Start();
                }
          
        }


        public void Cancel()
        {
 
            FrmDefault.ParamClass.FucMaterialDSSetStatus(3);
            Status = 0;
        }

    }
}
