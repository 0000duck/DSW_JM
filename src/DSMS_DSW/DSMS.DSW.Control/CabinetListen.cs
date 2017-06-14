using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

using System.Drawing;
using DSMS.DSW.OPC;

namespace DSMS.DSW.Control
{
    public class CabinetListen  //机台报警信号类 
    {
       private string PotCode;
       Label label= new Label();
       public System.Timers.Timer timer;
       delegate void Delegate_Fuc();
       public bool Alarm;
       string StatusId;
       public CabinetListen(string potCode, string id)
       {
           PotCode = potCode;
           StatusId = id;
       }

        /// <summary>
       /// 返回GroupBox控件
        /// </summary>
       public GroupBox GetCabientInfo(int width, DockStyle dc, string potCode, string potName)
       {
           GroupBox gb = new GroupBox();
           gb.Width = width;
           gb.Dock = dc;
           label.Dock = DockStyle.Fill;
           label.BorderStyle = BorderStyle.FixedSingle;
           label.TextAlign = ContentAlignment.MiddleCenter;
           label.ForeColor = Color.Black;
           label.Font = new Font("宋体",20,FontStyle.Bold);
           gb.Controls.Add(label);
           timer = new System.Timers.Timer(1000);
           timer.Elapsed += timer_Elapsed;
           timer.Enabled = true;
           Alarm = Golbal.ParamClass.IsAlarming(PotCode);
           Label();
           return gb;
       }

        
       public void timer_Elapsed(object sender, EventArgs e)
       {
           timer.Stop();
           Alarm = Golbal.ParamClass.IsAlarming(PotCode);
           Label();
           timer.Start();
       }

       /// <summary>
       /// 委托
       /// </summary>
       /// <param name="str"></param>
       private void Label()
       {
           if (this.label.InvokeRequired)
           {
               Delegate_Fuc delegate_Fuc = new Delegate_Fuc(Label);
               if (this.label.IsHandleCreated)
               {
                   label.Invoke(delegate_Fuc, new object[] { });
               }
           }
           else
           {
              label.BackColor = Alarm ? Color.DeepPink : Color.LimeGreen;
    
           }
       }  
    }
}