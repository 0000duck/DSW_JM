using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSMS.DSW.DAL;
using DSMS.DSW.Model;
using DSMS.DSW.Control.Action;
using System.Threading;

namespace DSMS.DSW.Control
{
    public partial class FrmWashing : Form
    {
        public FrmWashing()
        {
            InitializeComponent();
        }

        #region 公共变量
        System.Timers.Timer tMain;

        WashingCabinetWaterDS washingcabinetWaterDS;
        WashingMaterialDS washingmaterialDS;
        List<DS_DSMaterialModel> MaterialList ;
        DSW_FormulaDistributionDAL formulaDistributionDAL = new DSW_FormulaDistributionDAL();

        #endregion


        private void FrmWashing_Load(object sender, EventArgs e)
        {
            //dataView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体",15);
            LoadDevicePot();
            DS_DSMaterialDAL DSMaterialDAL = new DS_DSMaterialDAL();
            MaterialList = DSMaterialDAL.GetMaterialListAll();

            washingcabinetWaterDS = new WashingCabinetWaterDS();
            washingmaterialDS = new WashingMaterialDS();


            washingcabinetWaterDS.Competed_Event += Competed_Event;
            washingmaterialDS.Competed_Event += Competed_Event;

            washingcabinetWaterDS.PercentFinishEvent += PercentFinishEvent;

            Golbal.washingformulaStatus.Start_Event += Start_Event;
            Golbal.washingformulaStatus.End_Event += End_Event;
 
            tMain = new System.Timers.Timer(2000);
            tMain.Elapsed += tMain_Elapsed;
            tMain.Enabled = true;
            System.Timers.Timer tTimer = new System.Timers.Timer(500);
            tTimer.Elapsed += tTimer_Elapsed;
            tTimer.Start();
            
        }

        /// <summary>
        /// 加载机台缸
        /// </summary>
        private void LoadDevicePot()
        {
            DS_PotDAL potDAL = new DS_PotDAL();
            List<View_DeviceInfoModel> potList = potDAL.GetPotListByType(3);//获取所有缸信息

            int groupBoxWidth = panelAlarm.Width / potList.Count;
            foreach (View_DeviceInfoModel potModel in potList)
            {

                CabinetListen cabinetListen = new CabinetListen(potModel.PotCode, potModel.Id.ToString());
                GroupBox gb = cabinetListen.GetCabientInfo(panelAlarm.Width , DockStyle.Left, potModel.PotCode, potModel.PotName);
                gb.Width = groupBoxWidth + 1;
                gb.Text = Environment.NewLine + potModel.PotName;
                gb.ForeColor = Color.White;
                gb.Font = new System.Drawing.Font("宋体", 12, FontStyle.Regular);
                gb.Padding = new System.Windows.Forms.Padding(5, 20, 5, 5);
                gb.Tag = potModel.PotCode;
                panelAlarm.Controls.Add(gb);
                gb.BringToFront();
            }
        }


        //行号
        private void dataView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;  
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
            e.RowBounds.Location.Y,
            grid.RowHeadersWidth - 4,
            e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                grid.RowHeadersDefaultCellStyle.Font,
                rectangle,
                grid.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        #region 委托

        //<summary>
        //操作记录
        //</summary>
        //<param name="str"></param>
        public delegate void Delegate_FucStr(DsRecord dsRecord);
        private void RecordShow(DsRecord dsRecord)
        {
            if (this.dataView1.InvokeRequired)
            {
                Delegate_FucStr delegate_Fuc = new Delegate_FucStr(RecordShow);

                this.dataView1.Invoke(delegate_Fuc, new object[] { dsRecord });
            }
            else
            {
                int index = this.dataView1.Rows.Add();
                this.dataView1.Rows[index].Cells[0].Value = dsRecord.ActionName;
                this.dataView1.Rows[index].Cells[1].Value = dsRecord.MaterialName;
                this.dataView1.Rows[index].Cells[2].Value = dsRecord.DSQuantity;
                this.dataView1.Rows[index].Cells[3].Value = dsRecord.EntryDate;
                this.dataView1.Rows[index].Cells[4].Value = Golbal.WashingCurrentPotName;

                this.dataView1.FirstDisplayedScrollingRowIndex = this.dataView1.Rows.Count-1;
            }
        }
        #endregion 



        #region 配送事件
        //配方开始
        private void Start_Event(object sender, EventArgs e)
        {
            Golbal.WashingCurrentAction = "开始配送";
            lblPotName.LableShow(Golbal.WashingCurrentPotName);//机台缸号
            lblMaterialQuantity.LableShow(Golbal.CurrentWashingaModel.MaterialQuantity.ToString("0.00")); //单缸量
            lblCabinetWaterQuantity.LableShow(Golbal.CurrentWashingaModel.CabientWaterQuantity.ToString("0.00")); //单缸量
            if (Golbal.CurrentWashingaModel.CabientWaterQuantity > 0)
            {
                washingcabinetWaterDS.Excute(Golbal.ParamClass, Golbal.WashingCurrentPotCode, Golbal.CurrentWashingaModel.CabientWaterQuantity); //机台放水
                Golbal.WashingWaterStep = 1;//开始机台放水
            }
            else {
                Golbal.WashingWaterStep = 2;//跳过机台放水
                PercentFinishEvent(null,null);
            }
        }

        //达到机台放水百分比后开始配送助剂
        private void PercentFinishEvent(object sender, EventArgs e)
        {

            if (Golbal.CurrentWashingaModel.MaterialQuantity > 0)
            {
                DS_DSMaterialModel materialmodel = MaterialList.Find(s => s.Code == "80");
                DsMaterial dsMaterial = new DsMaterial();
                dsMaterial.MaterialId = materialmodel.Id.ToString();
                dsMaterial.MaterialCode = materialmodel.Code;
                dsMaterial.MaterialName = materialmodel.Name;
                dsMaterial.MaterialQuantity = Golbal.CurrentWashingaModel.MaterialQuantity;
                dsMaterial.Unit = materialmodel.Unit;
                dsMaterial.Price = materialmodel.Price.Value;
                washingmaterialDS.Excute(Golbal.ParamClass, Golbal.WashingCurrentPotCode, dsMaterial);//配送第一种助剂
                Golbal.WashingDSStep = 1;//开始配送助剂
            }
            else {
                Golbal.WashingDSStep = 2;//跳过配送助剂完成
            }
        }


        //配方结束
        private void End_Event(object sender, EventArgs e)
        {

            Golbal.WashingCurrentAction = "等待机台请求";
            //Thread.Sleep(2000);//休眠两秒


            Golbal.MyWashingList.Remove(Golbal.CurrentWashingaModel);

            //添加完成记录
            DSW_FormulaDistributionModel formulaDistributionModel = new DSW_FormulaDistributionModel();
            formulaDistributionModel.BarCode = Golbal.CurrentWashingaModel.BarCode;
            formulaDistributionModel.PotName = Golbal.WashingCurrentPotName;
            formulaDistributionModel.DSQuantity = Golbal.CurrentWashingaModel.MaterialQuantity + Golbal.CurrentWashingaModel.CabientWaterQuantity;
            formulaDistributionModel.RealQuantity = decimal.Parse(Golbal.ParamClass.水洗助剂配送实际)+ decimal.Parse(Golbal.ParamClass.水洗机台放水实际);
            formulaDistributionModel.RecordTime = DateTime.Now;
            formulaDistributionDAL.Add(formulaDistributionModel);
            Golbal.WashingDSStep = 0;
            Golbal.WashingWaterStep = 0;

            tMain.Start();
        }


        //动作完成事件
        private void Competed_Event(object sender, EventArgs e)
        {
            DsRecord dsRecord = new DsRecord();
            dsRecord.EntryDate = DateTime.Now.ToString("HH:mm:ss");
            //配送动作
            if (sender is WashingMaterialDS)
            {
                Golbal.WashingDSStep = 2; //助剂配送完成
                dsRecord.ActionName = "助剂配送";
                dsRecord.MaterialName = washingmaterialDS.CurrentDsMaterial.MaterialName;
                dsRecord.DSQuantity = decimal.Parse(Golbal.ParamClass.水洗助剂配送实际);
                Golbal.RecordAdd(Golbal.CurrentWashingaModel.Devicetype, Golbal.CurrentWashingaModel.BarCode, Golbal.WashingCurrentPotCode, dsRecord, washingmaterialDS.CurrentDsMaterial);//添加纪录
 
            }

            //机水动作
            if (sender is WashingCabinetWaterDS)
            {
                Golbal.WashingWaterStep = 2;// 机台放水完成
              
                dsRecord.ActionName = "机台放水";
                dsRecord.MaterialName = "水";
                dsRecord.DSQuantity = decimal.Parse(Golbal.ParamClass.水洗机台放水实际);

                Golbal.RecordAdd(Golbal.CurrentWashingaModel.Devicetype, Golbal.CurrentWashingaModel.BarCode, Golbal.WashingCurrentPotCode, dsRecord, washingcabinetWaterDS.CurrentDsMaterial);//添加纪录
            }


            if (Golbal.WashingDSStep == 2 && Golbal.WashingWaterStep == 2)
            {

                Golbal.WashingEndExcute();
            }
            RecordShow(dsRecord);


        }

        #endregion




        #region 循环 Timer

        /// <summary>
        /// 循环动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tMain_Elapsed(object sender, EventArgs e)
        {
            tMain.Stop();
            if (Golbal.WashingDSStep == 0 && Golbal.WashingWaterStep == 0)
            {
                if (Golbal.MyWashingList.Count > 0)
                    lock (Golbal.MyWashingList)
                    {
                        foreach (View_WashingModel washingmodel in Golbal.MyWashingList)
                        {

                            if (washingmodel != null)
                            {
                                Golbal.WashingExcute(washingmodel);
                                break;
                            }
                        }
                    }
            }
            tMain.Start();
        }


        private void tTimer_Elapsed(object sender, EventArgs e)
        {
            lblAction.LableShow(Golbal.WashingCurrentAction);//当前动作
            lblCabinetTotal.LableShow(Golbal.ParamClass.水洗机台配送总量);//机台总量
            lblDSQuantity.LableShow(Golbal.ParamClass.水洗助剂配送实际); //目标量  

        }

        #endregion


        //<summary>
        //异常停止
        //</summary>
        public  void FormulaEnd_Event(object sender, EventArgs e)
        {

            if (Golbal.WashingDSStep > 0)
            {
                washingmaterialDS.FormulaStopTest();
            }
            if (Golbal.WashingWaterStep > 0)
            {
                if (Golbal.WashingDSStep == 0)
                {
                    Golbal.WashingDSStep = 2;//助剂设置成完成
                }
                washingcabinetWaterDS.FormulaStopTest();
            }
           
        }
       
    }
}


