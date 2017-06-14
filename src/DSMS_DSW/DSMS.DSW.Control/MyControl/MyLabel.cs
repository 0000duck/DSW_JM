using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSMS.DSW.Control.MyControl
{
    public   class MyLabel :Label
    {
        public string RowId
        {
            get;
            set;
        }
        public int Sort
        {
            get;
            set;
        }

        public int SN
        {
            get;
            set;
        }


        public decimal Total
        {
            get;
            set;
        }

        public string PotCode
        {
            get;
            set;
        }
    }
}
