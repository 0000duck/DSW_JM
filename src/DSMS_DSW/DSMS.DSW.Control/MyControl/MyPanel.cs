using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using DSMS.DSW.DAL;
using DSMS.DSW.Model;

namespace DSMS.DSW.Control.MyControl
{
   public class MyPanel : Panel 
    {
       Dictionary<string, Panel> dc = new Dictionary<string, Panel>();
       public Color LabelForeColor { get; set; }
       public Font LabelFont { get; set; }
       public BorderStyle LabelBorderStyle { get; set; }
       public void SetPanel(List<DsMaterial> list)
       {
           this.Controls.Clear();
           decimal sum = 0;
           foreach (DsMaterial item in list)
           {
                   sum +=  item.MaterialQuantity;
           }
           dc.Clear();

           this.Controls.Add(GetPanel("合计", sum.ToString(), Color.LimeGreen, Color.Transparent));
           for (int i = list.Count - 1; i >=0; i--)
           {
               Color labelForeColor = LabelForeColor;
               
               Panel panel = GetPanel(list[i].MaterialName, list[i].MaterialQuantity.ToString(), labelForeColor, Color.Transparent);
               this.Controls.Add(panel);
               dc.Add(list[i].MaterialId,panel);
           }
           this.Controls.Add(GetPanel("助剂", "目标量(KG)", Color.DeepSkyBlue, Color.Transparent));
       }

       public void SetFinishLabel(string Id)
       { 
           Panel panel ;
           if (dc.TryGetValue(Id, out panel))
           {

               foreach (System.Windows.Forms.Control control in panel.Controls)
               {
                   if (control is Label)
                   {
                       control.ForeColor = Color.DeepPink;
                    
                   }
               }
           }
       }

       public void SetFinishAll()
       {
           foreach (Panel panel in dc.Values)
           {
               foreach (System.Windows.Forms.Control control in panel.Controls)
               {

                   control.ForeColor = Color.DeepPink;


               }
           }
       }
       


       public Panel GetPanel(string name,string quantity ,Color foreColor,Color backColor)
       {
           Panel panel = new Panel();
           panel.Dock = DockStyle.Top;
           panel.Height = (int)LabelFont.GetHeight()+2;
           panel.BackColor = backColor;
           panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           Label lblName = new Label();
           lblName.AutoSize = false;
           lblName.ForeColor = foreColor;
           lblName.Text = name;
           lblName.Dock = DockStyle.Fill;
           lblName.Font = LabelFont;
           lblName.BorderStyle = LabelBorderStyle;
           Label lblQuantity = new Label();
           lblQuantity.AutoSize = false;
           lblQuantity.ForeColor = foreColor;
           lblQuantity.Text = quantity;
           lblQuantity.Dock = DockStyle.Right;
           lblQuantity.Font = LabelFont;
           lblQuantity.Width = this.Width / 2;
           lblQuantity.BorderStyle = LabelBorderStyle;
           panel.Controls.Add(lblQuantity);
           panel.Controls.Add(lblName);
           return panel;
       }
    }
}
