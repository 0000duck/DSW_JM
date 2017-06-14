using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSMS.DSW.Control.MyControl
{
   public partial  class TLabel:Label
    {

       public TLabel()
       {
           SetStyle(
                 ControlStyles.UserPaint |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer , true);
                 this.DoubleBuffered = true;
       }

        delegate void Delegate_Fuc();
        delegate void Delegate_FucStr(string str);

         
        public void LableShow(string str)
        {
            if (this.InvokeRequired)
            {
                Delegate_FucStr delegate_Fuc = new Delegate_FucStr(LableShow);

                this.Invoke(delegate_Fuc, new object[] { str });
            }
            else
            {
                this.Text = str;
            }
        }
    }
}
