using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using DSMS.DSW.DAL;
using DSMS.DSW.Model;


namespace DSMS.DSW.Control.MyControl
{
    public partial class DelColumnPane : System.Windows.Forms.Panel 
    {

   
        public Color LabelForeColor { get; set; }

        Dictionary<string, Panel> dcPanel = new Dictionary<string, Panel>();
        //public Font LabelFont { get; set; }
        public BorderStyle LabelBorderStyle { get; set; }
        private Color TitleBackColor = Color.DimGray;
        private Color TitleForeColor = Color.White;
        private Font TitleFont = new Font("宋体",18,FontStyle.Bold);

        public DelColumnPane()
        {
            
        }

       public  delegate void DelegateReLoad();

       public  void ControlReLoad()
        {

            if (this.InvokeRequired)
            {
                DelegateReLoad delegate_Fuc = new DelegateReLoad(ControlReLoad);
                this.Invoke(delegate_Fuc);
            }
            else
            {
                LoadData();
            }


        }


        public  void LoadData()
        {
            dcPanel.Clear();
            this.Controls.Clear();
            AddTitel();
            foreach (View_FormulaInfoModel model in Golbal.MyQueueList.ToList())
            {
                AddPanel(model);
            }
        }

        public void AddPanel(View_FormulaInfoModel model)
        {
            Panel currentPanel = new Panel();
            currentPanel.Dock = DockStyle.Top;
            currentPanel.Height = (int)this.Font.GetHeight() + 20;
            currentPanel.BackColor = Color.Transparent;
            currentPanel.BorderStyle = LabelBorderStyle;
            currentPanel.Tag = model.BarCode;
            this.Controls.Add(currentPanel);
            currentPanel.BringToFront();
            if (!dcPanel.ContainsKey(model.BarCode))
            {
                dcPanel.Add(model.BarCode, currentPanel);
            }
            for (int i = 0; i < 6; i++)
            {
                Label lbl = new Label();
                lbl.Width = this.Width /7 + 1;
                lbl.AutoSize = false;
                lbl.ForeColor = this.ForeColor;

                switch (i)
                {
                    case 0: lbl.Text = model.BarCode; break;
                    case 1: lbl.Text = model.DeviceName; break;
                    case 2: lbl.Text = model.Customer; break;
                    case 3: lbl.Text = model.ProductSpecification; break;
                    case 4: lbl.Text = model.CylinderNum.ToString(); break;
                    case 5: lbl.Text = model.CompleteCylinderNum.ToString(); break;
                
                }

                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Dock = DockStyle.Left;
                lbl.Font = this.Font;
                lbl.BorderStyle = LabelBorderStyle;
                currentPanel.Controls.Add(lbl);
                lbl.BringToFront();
            }

            ButtonEx btn = new ButtonEx();
            btn.Text = "删除";
            btn.Font = this.Font;
            btn.Click += btn_Click;
            btn.Dock = DockStyle.Left;
            btn.Width = this.Width /7 + 1;
            btn.Tag = model.BarCode;
            currentPanel.Controls.Add(btn);
            btn.BringToFront();

        }

        //添加标签
        public void AddTitel()
        {
            string[] Title = new string[] { "配方编号", "机台", "客户", "产品规格", "目标缸数", "完成缸数", "操作" };

            Panel currentPanel = new Panel();
            currentPanel.Dock = DockStyle.Top;
            currentPanel.Height = (int)this.TitleFont.GetHeight() + 5;
            currentPanel.BackColor = Color.Transparent;
            currentPanel.BorderStyle = LabelBorderStyle;
            this.Controls.Add(currentPanel);
            currentPanel.BringToFront();
            for (int i = 0; i < Title.Length; i++)
            {
                Label lbl = new Label();
                lbl.Width = this.Width / Title.Length + 1;
                lbl.AutoSize = false;
                lbl.ForeColor = TitleForeColor;
                lbl.BackColor = TitleBackColor;
                lbl.Text = Title[i];
                lbl.Dock = DockStyle.Left;
                lbl.Font = TitleFont;
                lbl.BorderStyle = LabelBorderStyle;
                currentPanel.Controls.Add(lbl);
                lbl.BringToFront();
            }
        }

 

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string barCode = dcPanel[btn.Tag.ToString()].Tag.ToString();

            if (Golbal.DSStep > 0 && Golbal.CurrentFormulaModel.BarCode == barCode)
            {
                MessageBox.ShowTip("当前正在配送,无法删除!");
                return;
            }

            FrmMessageBox frmMessageBox = new FrmMessageBox();
            frmMessageBox.ShowYC("确定要删除" + dcPanel[btn.Tag.ToString()].Tag.ToString() + "配方？");
            if (frmMessageBox.DialogResult == DialogResult.OK)
            {

                lock (Golbal.MyQueueList)
                {
                    for (int i = 0; i < Golbal.MyQueueList.Count; i++)
                  {
                      Golbal.MyQueueList.RemoveAll(s => s.BarCode== barCode);
                      ControlReLoad();
                
                  }
                }
            }
        }  
    }
}
