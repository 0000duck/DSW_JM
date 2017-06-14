using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSMS.DSW.DAL;
using OPCHelper;
using DSMS.DSW.Model;

namespace DSMS.DSW.Control
{
    public partial class FrmParamSet : Form
    {
        public FrmParamSet()
        {
            InitializeComponent();
        }

        OpcReadAndWrite opcReadAndWrite;
        System.Timers.Timer tTimer;
        private void FrmParamSet_Load(object sender, EventArgs e)
        {

            List<DSW_ParamTableModel> ParamList = new List<DSW_ParamTableModel>();
            ParamList.Add(new DSW_ParamTableModel { Id = 80, LabelName = "皂洗剂密度", KepAddress = "PLC.PLC.QD632", RW = "R/W" });
            ParamList.Add(new DSW_ParamTableModel { Id = 90, LabelName = "软片v18密度", KepAddress = "PLC.PLC.QD600", RW = "R/W" });
            ParamList.Add(new DSW_ParamTableModel { Id = 91, LabelName = "整理剂密度", KepAddress = "PLC.PLC.QD604", RW = "R/W" });
            ParamList.Add(new DSW_ParamTableModel { Id = 92, LabelName = "软片v16密度", KepAddress = "PLC.PLC.QD608", RW = "R/W" });
            ParamList.Add(new DSW_ParamTableModel { Id = 93, LabelName = "硬挺剂密度", KepAddress = "PLC.PLC.QD612", RW = "R/W" });
            ParamList.Add(new DSW_ParamTableModel { Id = 94, LabelName = "尿素密度", KepAddress = "PLC.PLC.QD616", RW = "R/W" });
            ParamList.Add(new DSW_ParamTableModel { Id = 95, LabelName = "BX2密度", KepAddress = "PLC.PLC.QD620", RW = "R/W" });
            ParamList.Add(new DSW_ParamTableModel { Id = 96, LabelName = "蓬松硅乳密度", KepAddress = "PLC.PLC.QD624", RW = "R/W" });
            ParamList.Add(new DSW_ParamTableModel { Id = 97, LabelName = "蓬松柔软剂密度 ", KepAddress = "PLC.PLC.QD628", RW = "R/W" });
            opcReadAndWrite = new OpcReadAndWrite(ParamList);
            dataView1.DataSource = ParamList;
            tTimer = new System.Timers.Timer(200);
            tTimer.Elapsed += tTimer_Elapsed;
            tTimer.Start();
        }

        private void tTimer_Elapsed(object sender, EventArgs e)
        {
            tTimer.Stop();
            DataViewReSet();
            tTimer.Start();
        }

        
        private void dataView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
             e.RowBounds.Location.Y, dataView1.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dataView1.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dataView1.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            opcReadAndWrite.ConnDispose();
            this.Close();
        }



        delegate void DelegateReSet();
        public void DataViewReSet()
        {
            if (dataView1.InvokeRequired)
            {
                try
                {
                DelegateReSet del = new DelegateReSet(DataViewReSet);
                dataView1.Invoke(del);
                }
                catch{};
              
            }
            else
            {
                for (int i = 0; i < dataView1.Rows.Count; i++)
                {
                    DataGridViewRow dgvr = dataView1.Rows[i];
                    dgvr.Cells["CurrentValue"].Value = opcReadAndWrite.myDcValue[dgvr.Cells["KepAddress"].Value.ToString()];
                }

            }
        }


        private void dataView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow dgvr = dataView1.Rows[rowIndex];
            if (dgvr.Cells[e.ColumnIndex].Value.ToString()=="修改")
            {
                FrmNumSet frmNumSet = new FrmNumSet();
                decimal currentValue = 0;

                decimal.TryParse(dgvr.Cells["CurrentValue"].Value.ToString(), out currentValue);


                frmNumSet.Value = currentValue;
                if (frmNumSet.ShowDialog() == DialogResult.OK)
                {
                    opcReadAndWrite.SyncWrite(dgvr.Cells["KepAddress"].Value.ToString(), frmNumSet.Value.ToString());
                }

            }
        }
    }
}
