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
    public partial class FrmMonthCalendar : Form
    {
        public FrmMonthCalendar()
        {
            InitializeComponent();
        }
        public DateTime datetime { get; set; }

        private void FrmMonthCalendar_Load(object sender, EventArgs e)
        { 

        
            ucDateTimePicker1.Click += Click_Event;
            ucDateTimePicker1.DoubleClick += DoubleClick_Event;
        }

        private void Click_Event(object sender, EventArgs e)
        {
            DateTime dt = (DateTime)sender;
            datetime = dt;
            this.Close();
        }

        private void DoubleClick_Event(object sender, EventArgs e)
        {
            //  DateTime dt = (DateTime)sender;
        }
    }
}
