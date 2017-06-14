using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSMS.DSW.Model;
using DSMS.DSW.DAL;

namespace DSMS.DSW.Control
{
    public partial class FrmStandardFormula : Form
    {
        public FrmStandardFormula()
        {
            InitializeComponent();
        }
        

        private void FrmAlarmAndQueue_Load(object sender, EventArgs e)
        {
            DSW_FormulaStandardDAL formulaStandardDAL = new DSW_FormulaStandardDAL();
            dataView1.DataSource = formulaStandardDAL.GetView_DSW_FormulaStandard();
             

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
            e.RowBounds.Location.Y,
            grid.RowHeadersWidth - 4,
            e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                grid.RowHeadersDefaultCellStyle.Font,
                rectangle,
                grid.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

      
    }
}
