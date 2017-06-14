using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSMS.DSW.Control.MyControl;

namespace DSMS.DSW.Control
{
    public partial class FrmNumSet : Form
    {
        public FrmNumSet()
        {
            InitializeComponent();
        }

        private string _value="0";
        public decimal Value
        {

            get { return decimal.Parse(_value); }
            set
            {
                _value = value.ToString();
            }
        }

        private void FrmNumSet_Load(object sender, EventArgs e)
        {
            lblValue.Text = Value.ToString();
        }

      

        private void btnSure_Click(object sender, EventArgs e)
        {
            Value = decimal.Parse(lblValue.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            ButtonEx btn = (ButtonEx)sender;

            if (btn.Text == "重置")
            {
                _value = "0";
                 
            }
            else if (btn.Text == ".")
            {
                 
                if (!_value.Contains("."))
                {
                    _value += btn.Text;
                }
            }
            else if (btn.Text == "<—")
            {
                if (_value.Length > 1)
                    _value = _value.Remove(_value.Length - 1, 1);
                else {
                    _value = "0";
                }
            }
            else
            {
                if (_value == "0")
                {
                    _value = btn.Text;
                }
                else  
                {
                    _value += btn.Text;
                }
 
            }
            lblValue.Text = _value;
        }
    }
}
