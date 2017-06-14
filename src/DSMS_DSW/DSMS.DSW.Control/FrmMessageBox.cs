using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSMS.DSW.Control
{
    public partial class FrmMessageBox : Form //消息提示框
    {
        public FrmMessageBox()
        {
            InitializeComponent();
        }


        public void ShowYC(string mes)
        {
            this.lblMes.Text = mes;
            this.ShowDialog();
        
        }

        public void ShowTip(string mes)
        {
            this.lblMes.Text = mes;
            btnYes.Visible = false;
            btnCancel.Text = "确认";
            this.ShowDialog();

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
           
        }

       
    }

    public partial class MessageBox
    {

        public static void ShowYC(string mes)
        {
            FrmMessageBox frmMessageBox = new FrmMessageBox();
            frmMessageBox.ShowYC(mes);
        }

        public static void ShowTip(string mes)
        {
            FrmMessageBox frmMessageBox = new FrmMessageBox();
            frmMessageBox.ShowTip(mes);
        }
    }
     
}
