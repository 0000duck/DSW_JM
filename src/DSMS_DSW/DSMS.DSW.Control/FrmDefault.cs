using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Net.NetworkInformation;
using System.Diagnostics;
using DSMS.DSW.Control.BLL;
using DSMS.DSW.Control.Class;
using DSMS.DSW.Control.Action;
using DSMS.DSW.Control.Action.BLL;
using System.Threading.Tasks;

namespace DSMS.DSW.Control
{
    public partial class FrmDefault : Form
    {
        public FrmDefault()
        {
            InitializeComponent();
        }

        #region 公共变量
        private  MyControl.ButtonEx btnB;
        private  MyControl.ButtonEx btnA;
        #endregion


        private void FrmDefault_Load(object sender, EventArgs e)
        {
            new Golbal();
            if (Golbal.WaterModel == null)
            {
                MessageBox.ShowTip("读取助剂失败");
            }

            //this.WindowState = FormWindowState.Maximized;
            FrmMain frmMain = new FrmMain();
            frmMain.TopLevel = false;
            frmMain.Dock = DockStyle.Fill;
            frmMain.Show();

            FormsAutoSize.AutoSize(frmMain);
            this.panelA.Controls.Add(frmMain);
            FrmWashing frmWashing = new FrmWashing();
            frmWashing.TopLevel = false;
            frmWashing.Dock = DockStyle.Fill;
            frmWashing.Show();
          
            FormsAutoSize.AutoSize(frmWashing);
            this.panelB.Controls.Add(frmWashing);

            panelB.Visible = false;
            AddTabButton();

            TCPServer TCPServer = new TCPServer();
            TCPServer.Excute();
            TCPServer.WashingFormulaEnd += frmWashing.FormulaEnd_Event;//添加异常完成事件

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            panelB.Visible = false;
           

            btnA.BaseColor = Color.FromArgb(51, 161, 224);
            btnA.ForeColor = Color.Black;
            btnB.BaseColor = Color.Black;
            btnB.ForeColor = Color.White;
          
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            
            panelB.Visible = true;

            btnA.BaseColor = Color.Black;
            btnA.ForeColor = Color.White;
            btnB.BaseColor = Color.FromArgb(51, 161, 224);
            btnB.ForeColor = Color.Black;
            
        }

          /// <summary>
          /// 添加Tab按钮
          /// </summary>
        private  void AddTabButton()
        {
            // btnB
            this.btnB = new MyControl.ButtonEx();
            this.btnB.BackColor = System.Drawing.Color.Transparent;
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.BaseColor = System.Drawing.Color.Black;
            this.btnB.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnB.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnB.Location = new System.Drawing.Point(150, 0);
            this.btnB.Name = "btnB";
            this.btnB.Radius = 10;
            this.btnB.RoundStyle =MyControl.RoundStyle.Top;
            this.btnB.Size = new System.Drawing.Size(150, 45);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "水洗配送";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            this.panelButton.Controls.Add(this.btnB);
            // 
            // btnA
            this.btnA = new MyControl.ButtonEx();
            this.btnA.BackColor = System.Drawing.Color.Transparent;
            this.btnA.ForeColor = System.Drawing.Color.Black;
            this.btnA.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnA.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnA.Location = new System.Drawing.Point(0, 0);
            this.btnA.Name = "btnA";
            this.btnA.Radius = 10;
            this.btnA.RoundStyle = MyControl.RoundStyle.Top;
            this.btnA.Size = new System.Drawing.Size(150, 45);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "定型配送";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.BtnA_Click);
            this.panelButton.Controls.Add(this.btnA);
        }

        private void panelTop_DoubleClick(object sender, EventArgs e)
        {
            FrmNumSet frmNumSet = new FrmNumSet();
            if (frmNumSet.ShowDialog() == DialogResult.OK && frmNumSet.Value.ToString()=="112233")
            {
                FrmParamSet frmParamSet = new FrmParamSet();
                frmParamSet.ShowDialog();
            }
        }
         
    }
}
