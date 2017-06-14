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

namespace DSMS.DSW.Control
{
    public partial class FrmMaterialEdit : Form
    {
        public FrmMaterialEdit()
        {
            InitializeComponent();
        }

        public DsMaterial currentMaterial { get; set; } 
        DS_DSMaterialDAL materialDAL = new DS_DSMaterialDAL();
        private void FrmMaterialEdit_Load(object sender, EventArgs e)
        {
            numPanel1.ValueChange += ValueChange;
            combMaterial.DataSource  = materialDAL.GetMaterialList();
            combMaterial.DisplayMember = "Name";
            combMaterial.ValueMember = "Code";
            combMaterial.SelectedIndex=0;
            if (currentMaterial != null)
            {
                combMaterial.SelectedValue = currentMaterial.MaterialCode;
                txtTarget.Text = currentMaterial.MaterialQuantity.ToString();
                numPanel1.Value = txtTarget.Text;
            }
            else {
                currentMaterial = new DsMaterial();
            }
        }


        private void ValueChange(object sender, EventArgs e)
        {
            txtTarget.Text = sender.ToString();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            decimal target =decimal.Parse(txtTarget.Text);
            if(target==0)
            {
            MessageBox.ShowTip("目标量应大于零");
            return ;
            }
            this.DialogResult = DialogResult.OK;

             DS_DSMaterialModel materialModel = materialDAL.GetMaterialByCode(combMaterial.SelectedValue.ToString());
             currentMaterial.MaterialId = materialModel.Id.ToString();
             currentMaterial.MaterialName = materialModel.Name;
             currentMaterial.MaterialCode = materialModel.Code;
             currentMaterial.MaterialQuantity =decimal.Parse(target.ToString("0.000"));
             currentMaterial.Price = materialModel.Price.Value;
             currentMaterial.Unit = materialModel.Unit;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
