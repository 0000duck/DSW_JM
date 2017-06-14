using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simple.Data;

using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace DSMS.DSW.Control
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSure_Click(object sender, EventArgs e)
        {

            string userName = txtUserName.Text.Trim();
            string userPwd = txtUserPwd.Text.Trim();

            if (userName == "admin" && userPwd==DateTime.Now.ToString("yyyyMMdd"))
            {
                
               
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }


        public void SetWindowRegion()
        {

            System.Drawing.Drawing2D.GraphicsPath FormPath;

            FormPath = new System.Drawing.Drawing2D.GraphicsPath();

            Rectangle rect = new Rectangle(0, 22, this.Width, this.Height - 22);//this.Left-10,this.Top-10,this.Width-10,this.Height-10);                 

            FormPath = GetRoundedRectPath(rect, 10);

            this.Region = new Region(FormPath);

        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {

            int diameter = radius;

            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));

            GraphicsPath path = new GraphicsPath();

            //   左上角   

            path.AddArc(arcRect, 180, 90);

            //   右上角   

            arcRect.X = rect.Right - diameter;

            path.AddArc(arcRect, 270, 90);

            //   右下角   

            arcRect.Y = rect.Bottom - diameter;

            path.AddArc(arcRect, 0, 90);

            //   左下角   

            arcRect.X = rect.Left;

            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();

            return path;

        }

        protected override void OnResize(System.EventArgs e)
        {

            this.Region = null;

            SetWindowRegion();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
