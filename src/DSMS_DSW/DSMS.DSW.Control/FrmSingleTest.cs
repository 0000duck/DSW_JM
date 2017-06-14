using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSMS.DSW.DAL;
using DSMS.DSW.Control.Action;
using System.Threading.Tasks;
using System.Threading;

namespace DSMS.DSW.Control
{
    public partial class FrmSingleTest : Form
    {
        public FrmSingleTest()
        {
            InitializeComponent();
        }


        MaterialDS materialDS;
        FormulaStatus formulaStatus;
        public delegate void DelegateEnabel(Button btn, bool b);

        private void FrmSingleTest_Load(object sender, EventArgs e)
        {
            materialDS = new MaterialDS();
            materialDS.Competed_Event += Competed_Event;
            formulaStatus = new FormulaStatus();
            formulaStatus.Start_Event += Start_Event;
            numPanel1.ValueChange += num_Click;
            BindData();
            Task.Factory.StartNew(() => {
                while (true)
                { 
                    if (Golbal.ParamClass.助剂配送状态 == "2")
                    {
                      
                        Competed_Event(null,null);
                    }
                    Thread.Sleep(1000);
                }
            });
        }

        private void Start_Event(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnEnd.Enabled = true;
            DsMaterial dsMaterial = new DsMaterial();
            dsMaterial.MaterialCode = combMaterial.SelectedValue.ToString();
            dsMaterial.MaterialName = combMaterial.SelectedText;
            dsMaterial.MaterialQuantity =decimal.Parse(txtTarget.Text);
            string potCode = combPot.SelectedValue.ToString();
            if (cbkEnd.Checked)//末端排放
            {
                switch (potCode)
                {
                    case "211": potCode = "200"; break;
                    case "212": potCode = "200"; break;
                    case "221": potCode = "200"; break;
                    case "222": potCode = "200"; break;
                    case "231": potCode = "200"; break;
                    case "232": potCode = "200"; break;
                    case "241": potCode = "200"; break;
                    case "242": potCode = "200"; break;
                    case "251": potCode = "200"; break;
                    case "252": potCode = "200"; break;
                    case "261": potCode = "200"; break;
                    case "262": potCode = "200"; break;
                }
            }

            Golbal.ParamClass.OpcSyncWrite( DSMS.DSW.OPC.ParamClass.ParamEnum.助剂配送机台缸号, potCode);
            Golbal.ParamClass.OpcSyncWrite(DSMS.DSW.OPC.ParamClass.ParamEnum.助剂配送助剂编号, dsMaterial.MaterialCode);
            Golbal.ParamClass.OpcSyncWrite(DSMS.DSW.OPC.ParamClass.ParamEnum.助剂配送目标量, dsMaterial.MaterialQuantity.ToString());
            Golbal.ParamClass.OpcSyncWrite(DSMS.DSW.OPC.ParamClass.ParamEnum.助剂配送状态, "1");
        }


        private void Competed_Event(object sender, EventArgs e)
        {
            //Golbal.ParamClass.OpcSyncWrite(DSMS.DSW.OPC.ParamClass.ParamEnum.助剂配送状态, "0");

            ButtonEnabelSet(btnStart, true);
            ButtonEnabelSet(btnEnd, false);
        }

 

        private void BindData()
        {
            DS_PotDAL potDAL = new DS_PotDAL();
            combPot.DataSource = potDAL.GetPotListByType(2);
            combPot.ValueMember = "PotCode";
            combPot.DisplayMember = "PotName";
            combPot.SelectedIndex = 0;
            DS_DSMaterialDAL dsMaterialDAL = new DS_DSMaterialDAL();
            combMaterial.DataSource = dsMaterialDAL.GetMaterialByDistributionType(2);
            combMaterial.ValueMember = "Code";
            combMaterial.DisplayMember = "Name";
            combMaterial.SelectedIndex = 0;
        }



        private void num_Click(object sender, EventArgs e)
        {
            txtTarget.Text = sender.ToString();  
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Golbal.DSStep > 0)
            {
                MessageBox.ShowTip("当前正在执行自动配送");
                return;
            }

            if (decimal.Parse(txtTarget.Text) == 0)
            {
                MessageBox.ShowTip("配送目标不能为0");
                return;
            
            }
 
            Golbal.ParamClass.OpcSyncWrite(DSMS.DSW.OPC.ParamClass.ParamEnum.配方状态, "1");
            formulaStatus.FormulaStart(Golbal.ParamClass);

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Golbal.ParamClass.OpcSyncWrite(DSMS.DSW.OPC.ParamClass.ParamEnum.助剂配送状态, "2");
        }

        public void ButtonEnabelSet(Button btn, bool b)
        {
            if (btn.InvokeRequired)
            {
                DelegateEnabel del = new DelegateEnabel(ButtonEnabelSet);
                btn.Invoke(del, new object[] { btn, b });
            }

            else
            {
                btn.Enabled = b;

            }
        }


    }
}
