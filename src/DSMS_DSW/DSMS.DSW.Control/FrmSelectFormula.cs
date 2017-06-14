using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSMS.DSW.DAL;
using DSMS.DSW.Model;
using DSMS.DSW.Models;

namespace DSMS.DSW.Control
{
    public partial class FrmSelectFormula : Form
    {
        public FrmSelectFormula()
        {
            InitializeComponent();
        }

        List<DSW_FormulaStandardModel> standardModelList;
        List<View_DeviceInfoModel> deviceInfoModelList;
        DSW_FormulaStandardDAL formulaStandardDAL = new DSW_FormulaStandardDAL();
        DSW_FormulaStandardDetailDAL formulaStandardDetailDAL = new DSW_FormulaStandardDetailDAL();
        DSW_FormulaDetailDAL formulaDetailDAL = new DSW_FormulaDetailDAL();
        DS_DeviceDAL deviceDAL = new DS_DeviceDAL();
        BindingSource bindingSource = new BindingSource();


        private bool ischecked = false;
        public bool IsChecked
        {
            get { return ischecked; }
            set
            {
                ischecked = value;
            }
        }

        private void FrmSelectFormula_Load(object sender, EventArgs e)
        {
            dataView1.AutoGenerateColumns = false;
            standardModelList = formulaStandardDAL.GetList();
            combStandard.DataSource = standardModelList;
            combStandard.DisplayMember = "Name";
            combStandard.ValueMember = "Id";
            combStandard.SelectedIndex = 0;
            deviceInfoModelList = deviceDAL.GetPotCodeList(2);
            comboPot.DataSource = deviceInfoModelList;
            comboPot.DisplayMember = "PotName";
            comboPot.ValueMember = "PotCode";
            comboPot.SelectedIndex = 0;
            LoadData();
            LoadStandardQuantity();
        }


        private void combStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStandardQuantity();
        }

        private void LoadData()
        {
            Guid parnetId;
          
                if (Guid.TryParse(combStandard.SelectedValue.ToString(), out parnetId))
                {
                    List<DsMaterial> materialList = new List<DsMaterial>();
                    foreach (View_FormulaStandardDetailModel model in formulaStandardDAL.GetListByParnetId(parnetId))
                    {
                        DsMaterial dsMaterial = new DsMaterial();
                        dsMaterial.MaterialId = model.MatId.ToString();
                        dsMaterial.MaterialName = model.MatName;
                        dsMaterial.MaterialCode = model.MatCode;
                        dsMaterial.MaterialQuantity = model.MatQuantity.Value;
                        dsMaterial.Price = model.Price.Value;
                        dsMaterial.Unit = model.Unit;
                        materialList.Add(dsMaterial);
                    }
                    bindingSource.DataSource = materialList;
                    dataView1.DataSource = bindingSource;
                    DSW_FormulaStandardModel standardModel = standardModelList.SingleOrDefault(s => s.Id == parnetId);
                    IsChecked = standardModel.IsManualFeed;
                }
        }

        private void LoadStandardQuantity()
        {
            View_DeviceInfoModel model = deviceInfoModelList.SingleOrDefault(s => s.PotCode == comboPot.SelectedValue.ToString());
            if (model != null)
            {
                lblStandardQuantity.Text = model.StandardQuantity.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            //if (combStandard.Text == "请选择")
            //{
            //    MessageBox.ShowTip("请选择标准配方"); return;
            //}
            //if (comboDevice.Text == "请选择")
            //{
            //    MessageBox.ShowTip("请选择机台"); return;
            //}
            View_DeviceInfoModel deviceModel = deviceInfoModelList.SingleOrDefault(s => s.PotCode == comboPot.SelectedValue.ToString());
            
            View_FormulaInfoModel formulaDetailModel = new View_FormulaInfoModel();
            
            DSW_FormulaStandardModel standardModel = standardModelList.SingleOrDefault(s => s.Id == new Guid(combStandard.SelectedValue.ToString()));
            formulaDetailModel.Id = Guid.NewGuid();
            formulaDetailModel.BarCode = DateTime.Now.ToString("yyMMddHHmmss");
            formulaDetailModel.Quantity = decimal.Parse(lblStandardQuantity.Text);
            formulaDetailModel.StandardQuantity = decimal.Parse(lblStandardQuantity.Text);
            formulaDetailModel.CylinderNum = 1;
            formulaDetailModel.DeviceId = deviceModel.DeviceId;
            formulaDetailModel.DeviceName = deviceModel.DeviceName;
            formulaDetailModel.DeviceType = deviceModel.Type;
            formulaDetailModel.PotCode = deviceModel.PotCode;
            formulaDetailModel.IsManualFeed = IsChecked;
            formulaDetailModel.Remark = standardModel.Remark;
            formulaDetailModel.ManufactureOrderId = Guid.Empty;
            formulaDetailModel.FormulaName = "手动配送";
            formulaDetailModel.ManufactureOrderCode = "***";
            formulaDetailModel.Customer = "***"; ;
            formulaDetailModel.Color = "***";
            formulaDetailModel.ProductName = "***";
            formulaDetailModel.ProductSpecification = "***";
            formulaDetailModel.ProductWidth = "***";
            formulaDetailModel.Meter = "***";
            formulaDetailModel.LatestDate = DateTime.Now.AddYears(1);
            formulaDetailModel.Status = 0;
            formulaDetailModel.ClientIP = deviceModel.IP;
            formulaDetailModel.CompleteCylinderNum = 0;
            List<View_FormulaDetailInfoModel> list = new List<View_FormulaDetailInfoModel>();

            for (int i = 0; i < dataView1.Rows.Count; i++)
            {
                DataGridViewRow dgvr = dataView1.Rows[i];
                View_FormulaDetailInfoModel detailInfoModel = new View_FormulaDetailInfoModel();
                detailInfoModel.Id = Guid.NewGuid();
                detailInfoModel.BarCode = formulaDetailModel.BarCode;
                detailInfoModel.MaterialId = new Guid(dgvr.Cells["MaterialId"].Value.ToString());
                detailInfoModel.MaterialName = dgvr.Cells["MaterialName"].Value.ToString();
                detailInfoModel.MaterialCode = dgvr.Cells["MaterialCode"].Value.ToString();
                detailInfoModel.MaterialQuantity = decimal.Parse(dgvr.Cells["MaterialQuantity"].Value.ToString());
                detailInfoModel.Sort = i;
                detailInfoModel.Unit = dgvr.Cells["Unit"].Value.ToString();
                detailInfoModel.Price = decimal.Parse(dgvr.Cells["Price"].Value.ToString());
                detailInfoModel.DeviceId = deviceModel.Id;
                list.Add(detailInfoModel);
            }
            formulaDetailModel.list = list;


            if (formulaDetailModel.list.Count == 0)
            {
                MessageBox.ShowTip("请先添加助剂");
                return;
            }
            decimal materialSum = list.Sum(s => s.MaterialQuantity);
            decimal minStandardQuantity = Golbal.CleanWater + Golbal.IntervalWater * dataView1.RowCount + materialSum;
            decimal maxStandardQuantity = deviceModel.StandardQuantity.Value;
            if (decimal.Parse(lblStandardQuantity.Text) < minStandardQuantity)
            {
                MessageBox.ShowTip("机台缸量不能小于" + minStandardQuantity + ""); return;
            }
            if (decimal.Parse(lblStandardQuantity.Text) > maxStandardQuantity)
            {
                MessageBox.ShowTip("机台缸量不能大于" + maxStandardQuantity + ""); return;
            }
         
            try
            {

                Golbal.MyQueueList.Add(formulaDetailModel);
              
                MessageBox.ShowTip("添加到队列成功");
            }
            catch
            {
                MessageBox.ShowTip("添加到队列失败");
            }
        }

        private void dataView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow dgvr = dataView1.Rows[rowIndex];
                if (dgvr.Cells[e.ColumnIndex].Value.ToString() == "修改")
                {
                    FrmMaterialEdit frm = new FrmMaterialEdit();
                    frm.Text = "助剂修改";
                    frm.currentMaterial = (DsMaterial)bindingSource.Current;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        bindingSource.RemoveAt(e.RowIndex);
                        bindingSource.Insert(e.RowIndex, frm.currentMaterial);

                    }
                }
                else if (dgvr.Cells[e.ColumnIndex].Value.ToString() == "删除")
                {

                    bindingSource.RemoveCurrent();

                }
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            List<DsMaterial> list = (List<DsMaterial>)bindingSource.DataSource;
            if (list == null)
            {
                MessageBox.ShowTip("请先选择标准配方"); return;
            }
            FrmMaterialEdit frm = new FrmMaterialEdit();
            frm.Text = "助剂新增";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (list.Where(s => s.MaterialCode == frm.currentMaterial.MaterialCode).Count() > 0)
                {
                    MessageBox.ShowTip("不能添加重复助剂");
                }
                else
                {
                    bindingSource.Insert(bindingSource.Count, frm.currentMaterial);
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            IsChecked = IsChecked ? false : true;
        }

        private void lblStandardQuantity_Click(object sender, EventArgs e)
        {
            FrmNumSet frmNumSet = new FrmNumSet();
            decimal currentValue = 0;
            decimal.TryParse(lblStandardQuantity.Text, out currentValue);
            frmNumSet.Value = currentValue;
            if (frmNumSet.ShowDialog() == DialogResult.OK)
            {
                lblStandardQuantity.Text = frmNumSet.Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            Guid parentId;
            if (!Guid.TryParse(combStandard.SelectedValue.ToString(), out parentId))
            {
                MessageBox.ShowTip("请先选择标准配方"); return;
            }
            List<DSW_FormulaStandardDetailModel> list = new List<DSW_FormulaStandardDetailModel>();
            for (int i = 0; i < dataView1.Rows.Count; i++)
            {
                DataGridViewRow dgvr = dataView1.Rows[i];
                DSW_FormulaStandardDetailModel detailModel = new DSW_FormulaStandardDetailModel();
                detailModel.Id = Guid.NewGuid();
                detailModel.ParentId = parentId;
                detailModel.Sort = i;
                detailModel.DSMaterialId = new Guid(dgvr.Cells["MaterialId"].Value.ToString());
                detailModel.Quantity = decimal.Parse(dgvr.Cells["MaterialQuantity"].Value.ToString());
                detailModel.Concentration = 0;
                detailModel.Type = 0;
                list.Add(detailModel);
            }
            if (formulaStandardDetailDAL.UpdateFormulaStandard(parentId, list))
            {
                formulaDetailDAL.UpdateDSW_FormulaDetailNewBarCode(parentId);
                MessageBox.ShowTip("保存成功");
            }
            else {
                MessageBox.ShowTip("保存失败");
            }

        }
    }
}
