using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSMS.DSW.DAL;

namespace DSMS.DSW.Control
{
    public partial class FrmRecordSearch : Form
    {
        public FrmRecordSearch()
        {
            InitializeComponent();
        }
        DS_RecordDAL recordDAL = new DS_RecordDAL();
        private void FrmRecordSearch_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
            Search(DateTime.Now);
        }

        private void Search(DateTime datetime)
        {
            dxPager1.Order = "EntryDate";
            dxPager1.SqlStr = recordDAL.GetListByDate(datetime);
            dxPager1.GridControl = dataView1;
            //dxPager1.DataToBind();
            dxPager1.ReLoad();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

            FrmMonthCalendar frm = new FrmMonthCalendar();
            frm.ShowDialog();
            dxPager1.Order = "EntryDate";
            dxPager1.SqlStr = recordDAL.GetListByDate(frm.datetime);
            dxPager1.GridControl = dataView1;
            //dxPager1.DataToBind();
            dxPager1.ReLoad();

            lblDateTime.Text = frm.datetime.ToString("yyyy-MM-dd");
        }


    }
}
