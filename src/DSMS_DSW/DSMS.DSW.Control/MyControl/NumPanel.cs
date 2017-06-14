using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace DSMS.DSW.Control.MyControl
{
    public class NumPanel : Panel
    {

        public EventHandler ValueChange;

        public NumPanel()
        {
            AddBtn();
        }

        private string _value;
        [DefaultValue("0")]
        public string Value
        {
            get { return _value; }
            set { _value = value; }

        }

        protected override void OnSizeChanged(EventArgs e)
        {
            BtnWidth = (this.Width + 1) / 12;
            base.OnSizeChanged(e);
        }


        public override System.Drawing.Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                foreach (System.Windows.Forms.Control c in this.Controls)
                {
                    if (c is ButtonEx)
                    {
                        c.Font = value;
                    }
                }

                base.Font = value;
            }

        }

        [Description("按钮宽度")]
        [DefaultValue("10")]
        public int BtnWidth
        {
            set
            {
                foreach (System.Windows.Forms.Control c in this.Controls)
                {
                    if (c is ButtonEx)
                    {
                        c.Width = value;
                    }
                }
            }
        }

        private void AddBtn()
        {

            for (int i = 0; i < 10; i++)
            {
                ButtonEx btn = new ButtonEx();
                btn.Text = i.ToString();
                btn.Font = this.Font;
                btn.Radius = 15;
                btn.Width = 10;
                btn.Dock = DockStyle.Left;
                btn.Click += btn_Click;
                this.Controls.Add(btn);
                btn.BringToFront();
            }

            ButtonEx btnDot = new ButtonEx();
            btnDot.Text = ".";
            btnDot.Font = this.Font;
            btnDot.Radius = 15;
            btnDot.Width = 10;
            btnDot.Dock = DockStyle.Left;
            btnDot.Click += btn_Click;
            this.Controls.Add(btnDot);
            btnDot.BringToFront();

            ButtonEx btnDel = new ButtonEx();
            btnDel.Text = "清零";
            btnDel.Font = this.Font;
            btnDel.Radius = 15;
            btnDel.Width = 10;
            btnDel.Dock = DockStyle.Left;
            btnDel.Click += btn_Click;
            this.Controls.Add(btnDel);
            btnDel.BringToFront();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ButtonEx btn = (ButtonEx)sender;

            if (btn.Text == "清零")
            {
                if (_value != null)
                {
                    //if (_value.Length > 1)
                    //{
                    //    _value = _value.Remove(_value.Length - 1);
                    //}
                    //else
                    //{
                        _value = "0";
                    //}
                }
                else
                {
                    _value = "0";
                }
            }
            else if (btn.Text == ".")
            {
                if (string.IsNullOrEmpty(_value))
                {
                    _value = "0";

                }
                if (!_value.Contains("."))
                {
                    _value += btn.Text;
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

            ValueChange(Value, null);
        }

    }
}
