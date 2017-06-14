using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace DSMS.DSW.Control.MyControl
{
   public class MyLabelPanel : Panel 
    {
       public Color LabelForeColor { get; set; }
       public Font LabelFont { get; set; }
       public BorderStyle LabelBorderStyle { get; set; }
       int   panelCount =  0;
       public decimal oMaterial;
       public decimal oWater;
       public int CabinetType{get;set;}
       delegate void Delegate_Fuc();
       public MyLabelPanel()
       {
           CabinetType = 0;
           InitializeComponent();
           this.Invalidate();
       }

       public void ResetPanel()
       {
           if (this.InvokeRequired)
           {
               Delegate_Fuc delegate_Fuc = new Delegate_Fuc(ResetPanel);
               this.Invoke(delegate_Fuc);
           }
           else
           {
               this.Controls.Clear();
               panelCount = 0;
               oMaterial = 0;
               oWater = 0;
               this.Invalidate();
           }
       }


       public void AddPanel(DsRecord dsRecord)
       {    
           Panel panel = new Panel();
           panel.Height = (int)LabelFont.GetHeight() + 2;
           panel.BackColor = this.BackColor;
           panel.Dock = DockStyle.Top;
           panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

           if (dsRecord.MaterialName == "水" || dsRecord.MaterialName == "间隔水" || dsRecord.MaterialName == "清洗水")
           {
               oWater += dsRecord.DSQuantity;
           }
           else {
               oMaterial += dsRecord.DSQuantity;
           }
           Label labelNum = new Label();
           labelNum.AutoSize = false;
           labelNum.ForeColor = LabelForeColor;
           panelCount++;
           labelNum.Text = panelCount.ToString();
           labelNum.TextAlign = ContentAlignment.MiddleRight;
           labelNum.Dock = DockStyle.Right;
           labelNum.Font = LabelFont;
           labelNum.BorderStyle = LabelBorderStyle;
           labelNum.Width = 50;
           panel.Controls.Add(labelNum);
           int[] labelWidth = new int[]{120,120,120,this.Width-400 };

           string[] ls = new string[] { dsRecord.ActionName,dsRecord.MaterialName,dsRecord.DSQuantity.ToString("0.00"),dsRecord.EntryDate };

           for (int i = 0; i < ls.Length; i++)
           {
               Label label = new Label();
               label.AutoSize = false;
               label.ForeColor = LabelForeColor;
               label.Text =ls[i];
               label.Dock = DockStyle.Right;
               label.Font = LabelFont;
               label.BorderStyle = LabelBorderStyle;
               label.Width = labelWidth[i];
               panel.Controls.Add(label);
           }
           this.Controls.Add(panel);
           panel.BringToFront();
           this.Invalidate();
       }

        private decimal GetDecimal(string str)
       {
           decimal oValue = 0;
           decimal.TryParse(str, out oValue);
           return oValue;
       }

        private void InitializeComponent()
        {
            this.SuspendLayout();
      
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MyLabelPanel_Paint);
            this.ResumeLayout(false);
        }

    
        private void MyLabelPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                Font f = new Font("宋体",16, FontStyle.Bold);
                Rectangle rect1 = new Rectangle(0, this.Height - 30, this.Width /2, 30);
                Rectangle rect2 = new Rectangle(this.Width /2, this.Height - 30, this.Width /2, 30);
                
               
                g.DrawString("█物料总量:" + oMaterial, f, Brushes.LimeGreen, rect1);
                g.DrawString("█耗水总量:" + oWater, f, Brushes.DeepSkyBlue, rect2);
                 
             
            }
        }
    }
}
