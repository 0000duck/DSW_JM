using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DSMS.DSW.Control
{
    public class FormsAutoSize
    {
        public float X, Y;
        public System.Windows.Forms.Form myForm;

        public void AutoSize(System.Windows.Forms.Form frm)
        {
            myForm = frm;
            myForm.Resize += new EventHandler(FrmMain_Resize);
            X = myForm.Width;
            Y = myForm.Height;
            setTag(myForm);
        }
        #region 自适应窗体大小
        public void setTag(System.Windows.Forms.Control cons)
        {
            foreach (System.Windows.Forms.Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }

        public void setControls(float newx, float newy, System.Windows.Forms.Control cons)
        {
            foreach (System.Windows.Forms.Control con in cons.Controls)
            {

                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * newy;
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (cons.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }

        }

        public void FrmMain_Resize(object sender, EventArgs e)
        {
            // throw new Exception("The method or operation is not implemented.");  
            float newx = (myForm.Width) / X;
            //  float newy = (this.Height - this.statusStrip1.Height) / (Y - y);  
            float newy = myForm.Height / Y;
            setControls(newx, newy, myForm);
            //myForm.Text = myForm.Width.ToString() + " " + myForm.Height.ToString();

        }
        #endregion

    }
}
