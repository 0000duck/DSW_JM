
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSMS.DSW.Control.MyControl;
using System.Diagnostics;
using System.Runtime.InteropServices;
using DSMS.DSW.DAL;
using System.Threading;
using DSMS.DSW.Model;
using DSMS.DSW.OPC;
using DSMS.DSW.Control.Action;
using DSMS.DSW.Control.BLL;
using System.Threading.Tasks;

namespace DSMS.DSW.Control
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
         
        #region 公共变量
        System.Timers.Timer tMain;
        
        CabinetWaterDS cabinetWaterDS ;
        MaterialDS materialDS;
        EndWaterDS endWaterDS;
        DSW_FormulaDAL formulaDAL = new DSW_FormulaDAL();
        DSW_FormulaDistributionDAL formulaDistributionDAL = new DSW_FormulaDistributionDAL();
        WcfService wcfService = new WcfService();//实时配送信息
        #endregion
        
         
        private void FrmMain_Load(object sender, EventArgs e)
        {
            cabinetWaterDS = new CabinetWaterDS();
            materialDS  = new MaterialDS();
            endWaterDS = new EndWaterDS();

            cabinetWaterDS.Competed_Event += Competed_Event;
            materialDS.Competed_Event += Competed_Event;
            endWaterDS.Competed_Event += Competed_Event;

            cabinetWaterDS.PercentFinishEvent += PercentFinishEvent;

            Golbal.formulaStatus.Start_Event+=Start_Event;
            Golbal.formulaStatus.End_Event += End_Event;
 
        
            LoadButton();
            tMain = new System.Timers.Timer(2000);
            tMain.Elapsed += tMain_Elapsed;
            tMain.Enabled = true;
            System.Timers.Timer tTimer = new System.Timers.Timer(500);
            tTimer.Elapsed += tTimer_Elapsed;
            tTimer.Start();

            wcfService.Excute();
        }

        #region 委托
        /// <summary>
        /// 当前生产项
        /// </summary>
        /// <param name="str"></param>
        public  delegate void  Delegate_Fuc();
        private void FormulaDetailShow()
        {
            if (myPanel.InvokeRequired)
            {
                Delegate_Fuc delegate_Fuc = new Delegate_Fuc(FormulaDetailShow);
                this.myPanel.Invoke(delegate_Fuc);
            }
            else
            {
                myPanel.SetPanel(Golbal.MaterialQueue.ToList());
            }
        }



         //<summary>
         //操作记录
         //</summary>
         //<param name="str"></param>
        public delegate void Delegate_FucStr(DsRecord dsRecord);
        private void RecordShow(DsRecord dsRecord)
        {
            if (this.myLabelPanel.InvokeRequired)
            {
                Delegate_FucStr delegate_Fuc = new Delegate_FucStr(RecordShow);

                this.myLabelPanel.Invoke(delegate_Fuc, new object[] { dsRecord });
            }
            else
            {
                this.myLabelPanel.AddPanel(dsRecord);
            }
        }
        #endregion 

        #region 配送事件
        //配方开始
        private void Start_Event(object sender, EventArgs e)
        {
          this.myLabelPanel.ResetPanel();
          lblCustomer.LableShow(Golbal.CurrentFormulaModel.Customer);//客户名称
          lblProductName.LableShow(Golbal.CurrentFormulaModel.ProductName);//产品名称
          lblProductSpecification.LableShow(Golbal.CurrentFormulaModel.ProductSpecification);//产品规格

       
          lblPotName.LableShow(Golbal.CurrentPotName);//机台缸号
          lblCurrentQuantity.LableShow(Golbal.CurrentFormulaModel.Quantity.ToString("0.00")); //单缸量

         
          lblTotalQuantity.LableShow(Golbal.CurrentFormulaModel.CylinderNum.ToString());//总缸数
          lblCompleteQuantity.LableShow(Golbal.CurrentFormulaModel.CompleteCylinderNum.ToString());//完成缸数
          FormulaDetailShow();
          cabinetWaterDS.Excute(Golbal.ParamClass, Golbal.CurrentPotCode, Golbal.CurrentCabinetWaterQuantity); //机台放水
          
        }
                                                                                                                                                                                                                                                                                                                                  
        //达到机台放水百分比后开始配送助剂
        private void PercentFinishEvent(object sender ,EventArgs e)
        {
            DsMaterial dsMaterial = Golbal.MaterialQueue.Dequeue();
            materialDS.Excute(Golbal.ParamClass, Golbal.CurrentPotCode, dsMaterial);//配送第一种助剂
        }


        //配方结束
        private void End_Event(object sender, EventArgs e)
        {

            Golbal.CurrentAction = "等待机台请求";
            Thread.Sleep(2000);//休眠两秒

            if (Golbal.CurrentFormulaModel.CompleteCylinderNum +1>= Golbal.CurrentFormulaModel.CylinderNum)
            {
                Golbal.CurrentFormulaModel.CompleteCylinderNum = Golbal.CurrentFormulaModel.CylinderNum;
                Golbal.MyQueueList.RemoveAt(0);
            }
            else {
                Golbal.CurrentFormulaModel.CompleteCylinderNum++;
            }

            lblCompleteQuantity.LableShow(Golbal.CurrentFormulaModel.CompleteCylinderNum.ToString());
            //添加完成记录
            DSW_FormulaDistributionModel formulaDistributionModel = new DSW_FormulaDistributionModel();
            formulaDistributionModel.BarCode = Golbal.CurrentFormulaModel.BarCode;
            formulaDistributionModel.PotName = Golbal.CurrentPotName;
            formulaDistributionModel.DSQuantity = Golbal.CurrentFormulaModel.Quantity / Golbal.CurrentFormulaModel.CylinderNum;
            formulaDistributionModel.RealQuantity = decimal.Parse(Golbal.ParamClass.配送总量实际);
            formulaDistributionModel.RecordTime = DateTime.Now;
            formulaDistributionDAL.Add(formulaDistributionModel);
            Golbal.DSStep = 0;
            Golbal.WaterStep = 0;

            tMain.Start();
        }


        //动作完成事件
        private void Competed_Event(object sender, EventArgs e)
        {
            DsRecord dsRecord = new DsRecord();
            dsRecord.EntryDate = DateTime.Now.ToString("HH:mm:ss");
            //配送动作
            if (sender is MaterialDS)
            {
                dsRecord.ActionName = "助剂配送";
                dsRecord.MaterialName = materialDS.CurrentDsMaterial.MaterialName;
                dsRecord.DSQuantity = decimal.Parse(Golbal.ParamClass.助剂配送实际);
                Golbal.RecordAdd(Golbal.CurrentFormulaModel.DeviceType, Golbal.CurrentFormulaModel.BarCode, Golbal.CurrentPotCode, dsRecord, materialDS.CurrentDsMaterial);//添加纪录
              
                if (Golbal.DSStep == 1) //助剂配送完成
                {
                    Golbal.DSStep = 2;
                    myPanel.SetFinishLabel(materialDS.CurrentDsMaterial.MaterialId); //设置完成标识
                    DsMaterial dsMaterial = new DsMaterial();
                    dsMaterial.MaterialId = Golbal.WaterModel.Id.ToString();
                    dsMaterial.MaterialCode = Golbal.WaterModel.Code;
                    dsMaterial.MaterialName = "间隔水";
                    dsMaterial.MaterialQuantity = Golbal.IntervalWater;
                    dsMaterial.Unit = Golbal.WaterModel.Unit;
                    dsMaterial.Price = Golbal.WaterModel.Price.Value;
                    materialDS.Excute(Golbal.ParamClass, Golbal.CurrentPotCode, dsMaterial); //间隔水 

                }

                else if (Golbal.DSStep == 2)//间隔水完成
                {
                    if (Golbal.MaterialQueue.Count > 0)
                    {
                        Golbal.DSStep = 1;
                        DsMaterial dsMaterial = Golbal.MaterialQueue.Dequeue();
                        materialDS.Excute(Golbal.ParamClass, Golbal.CurrentPotCode, dsMaterial);//助剂配送
                    }
                    else
                    {
                        Golbal.DSStep = 3;
                        DsMaterial dsMaterial = new DsMaterial();
                        dsMaterial.MaterialId = Golbal.WaterModel.Id.ToString();
                        dsMaterial.MaterialCode = Golbal.WaterModel.Code;
                        dsMaterial.MaterialName = "清洗水";
                        dsMaterial.MaterialQuantity = Golbal.CleanWater;
                        dsMaterial.Unit = Golbal.WaterModel.Unit;
                        dsMaterial.Price = Golbal.WaterModel.Price.Value;
                        materialDS.Excute(Golbal.ParamClass, Golbal.CurrentPotCode, dsMaterial); //管道清洗
                    }

                }
                else if (Golbal.DSStep == 3)//清洗水完成
                {
                    Golbal.DSStep = 4;

                    endWaterDS.Excute(Golbal.ParamClass, Golbal.CurrentPotCode, "99", Golbal.EndWater);
                }
                
            }

            //末端动作
            if (sender is EndWaterDS) //末端排放完成
            {
                Golbal.DSStep = 5;

                Golbal.CurrentAction = "等待机台放水中";
                if (Golbal.WaterStep == 2)  //当机台放水完成
                {
                    Golbal.EndExcute();
                }
                dsRecord.ActionName = "末端排放";
                dsRecord.MaterialName = "水";
                dsRecord.DSQuantity = decimal.Parse(Golbal.ParamClass.助剂配送实际);

                Golbal.RecordAdd(Golbal.CurrentFormulaModel.DeviceType, Golbal.CurrentFormulaModel.BarCode, Golbal.CurrentPotCode, dsRecord, endWaterDS.CurrentDsMaterial);//添加纪录
            }
            //机水动作
            if (sender is CabinetWaterDS)
            {
                Golbal.WaterStep = 2;
                if (Golbal.DSStep == 5)//当末端排放完成
                {
                    Golbal.EndExcute();
                }
                dsRecord.ActionName = "机台放水";
                dsRecord.MaterialName = "水";
                dsRecord.DSQuantity = decimal.Parse(Golbal.ParamClass.机台放水实际);

                Golbal.RecordAdd(Golbal.CurrentFormulaModel.DeviceType, Golbal.CurrentFormulaModel.BarCode, Golbal.CurrentPotCode, dsRecord, cabinetWaterDS.CurrentDsMaterial);//添加纪录
            }
      
            RecordShow(dsRecord);

          
        }

        #endregion


        #region 加载按钮
        private void LoadButton()
        {
            int btnCount = 7;

            for (int i = 0; i < btnCount; i++)
            {
                ButtonEx btn = new ButtonEx();
                btn.Height = panelBottom.Height;
                btn.Width = panelBottom.Width / btnCount + 1;
                btn.Click += button_Click;
                btn.Dock = DockStyle.Right;
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Popup;
                btn.Name = i.ToString();
                btn.Font = new Font("宋体", btn.Width * 0.1f);
                btn.RoundStyle = RoundStyle.All;
                switch (i)
                {
                    case 0: btn.Text = "F1" + Environment.NewLine + "配方下单"; break;
                    case 1: btn.Text = "F2" + Environment.NewLine + "异常停止"; break;
                    case 2: btn.Text = "F3" + Environment.NewLine + "请求队列"; break;
                    case 3: btn.Text = "F4" + Environment.NewLine + "历史记录"; break;
                    case 4: btn.Text = "F5" + Environment.NewLine + "标准配方"; break;
                    case 5: btn.Text = "F6" + Environment.NewLine + "单步测试"; break;
                    case 6: btn.Text = "F7" + Environment.NewLine + "退出程序"; break;
                }

                panelBottom.Controls.Add(btn);
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            string str = string.Empty; ;
            if (sender is Button)
            {
                Button btn = (Button)sender;
                str = btn.Name;
            }
            //if (sender is ToolStripMenuItem)
            //{
            //    ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            //    str = tsmi.Tag.ToString();
            //}
            switch (str)
            {
                case "0": SelectFormula(); break;
                case "1": FormulaEnd(); break;
                case "2": AlarmAndQueue(); break;
                case "3": DistributionRecord(); break;
                case "4": StandardFormulaView(); break;
                case "5": SingleTest(); break;              
                case "6": ApplicationKill(); break;

            }
        }


        //<summary>
        //配方
        //</summary>
        FrmSelectFormula frmSelectFormula = new FrmSelectFormula();
        private void SelectFormula()
        { if (frmSelectFormula.Visible == false)
            {

                frmSelectFormula = new  FrmSelectFormula();
                frmSelectFormula.Show();
            }
            else
            {
                frmSelectFormula.Close();
            }
            frmSelectFormula.Activate();
        }

        //<summary>
        //异常停止
        //</summary>
        private void FormulaEnd()
        {
            if (Golbal.DSStep > 0 && Golbal.DSStep<4)
            {
                FrmMessageBox frmMessageBox = new FrmMessageBox();
                frmMessageBox.ShowYC("确定要停止?");
                if (frmMessageBox.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    Golbal.MaterialQueue.Clear();
                    myPanel.SetFinishAll();
                    cabinetWaterDS.FormulaStop();
                    materialDS.FormulaStop();
                    endWaterDS.FormulaStop();
                    frmMessageBox.ShowYC("是否末端排放");
                    if (frmMessageBox.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {

                        Task.Factory.StartNew(() =>   //线程执行任务
                        {
                            endWaterDS.Excute(Golbal.ParamClass, Golbal.CurrentPotCode, "99", Golbal.CleanWater);
                        });

                    }
                    else
                    {
                        Task.Factory.StartNew(() =>  //线程执行任务
                        {
                            Golbal.EndExcute();
                        });
                    }
                }
            }
        }
        //<summary>
        //请求队列
        //</summary>
        FrmAlarmAndQueue frmAlarmAndQueue = new FrmAlarmAndQueue();
        private void AlarmAndQueue()
        {
            if (frmAlarmAndQueue.Visible == false)
            {
                //frmAlarmAndQueue.WindowState = FormWindowState.Maximized;
                frmAlarmAndQueue.Show();
            }
            else
            {
                frmAlarmAndQueue.Visible = false;
            }
            frmAlarmAndQueue.Activate();
        }
        //<summary>
        //历史记录
        //</summary>
        private void DistributionRecord()
        {
            //if (frmRecordSearch.Visible == false)
            //{
 
            //    //frmRecordSearch.WindowState = FormWindowState.Maximized;
            //    frmRecordSearch.Show();
            //}
            //else
            //{
            //    frmRecordSearch.Visible = false;
            //}
            //frmRecordSearch.Activate();
            FrmRecordSearch frmRecordSearch = new FrmRecordSearch();
            frmRecordSearch.ShowDialog();
        }

        //<summary>
        //标准配方
        //</summary>

        private void StandardFormulaView()
        {
            FrmStandardFormula frm = new FrmStandardFormula();
            frm.ShowDialog();
        }

        //<summary>
        //单步测试
        //</summary>
       
        private void SingleTest()
        {
        //    if (frmSingleTest.Visible == false)
        //    {

        //        frmSingleTest = new FrmSingleTest();
        //        frmSingleTest.Show();
        //    }
        //    else
        //    {
        //        frmSingleTest.Close();
        //    }
        //    frmSingleTest.Activate();
            FrmSingleTest frmSingleTest = new FrmSingleTest();
            frmSingleTest.ShowDialog();
        }
   
        //<summary>
        //退出
        //</summary>
        private void ApplicationKill()
        {
            FrmMessageBox frmMessageBox = new FrmMessageBox();
            frmMessageBox.ShowYC("确定要退出程序?");
            if (frmMessageBox.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Golbal.ParamClass.Dispose();
                Process.GetCurrentProcess().Kill();
            }
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
            if (Golbal.DSStep == 0 && Golbal.WaterStep == 0)
            {
                if (Golbal.MyQueueList.Count > 0)
                    lock (Golbal.MyQueueList)
                    {

                        if (Golbal.MyQueueList.Count > 0)
                        {
                            View_FormulaInfoModel model = Golbal.MyQueueList[0];
                            Golbal.Excute(model, model.PotCode);
                        }

                        //foreach (View_FormulaInfoModel model in Golbal.MyQueueList)
                        //{
                        //    //foreach (DS_PotModel potModel in Golbal.potList.Where(s => s.DeviceId == model.DeviceId).ToList())
                        //    //{
                        //    //    if (Golbal.ParamClass.IsAlarming(potModel.PotCode))
                        //    //    {
                        //    Golbal.Excute(model, model.PotCode);
                        //    //    }
                        //    //}
                        //}

                    }
            }
            tMain.Start();
        }


        private void tTimer_Elapsed(object sender, EventArgs e)
        {
            lblCurrent.LableShow(Golbal.CurrentAction);//显示当前动作
            lblCabinetWater.LableShow(Golbal.ParamClass.机台放水实际);//机台放水
            lblDSTotal.LableShow(Golbal.ParamClass.配送总量实际); //实际总量
            lblDSQuantity.LableShow(Golbal.ParamClass.助剂配送实际); //目标量  
        }

        #endregion

    }
}
