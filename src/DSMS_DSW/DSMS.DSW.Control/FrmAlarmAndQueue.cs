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
    public partial class FrmAlarmAndQueue : Form
    {
        public FrmAlarmAndQueue()
        {
            InitializeComponent();
        }
        

        private void FrmAlarmAndQueue_Load(object sender, EventArgs e)
        {
            LoadDevicePot();
            delColumnPane1.ControlReLoad();

        }


        private void ControlReLoad(object sender, EventArgs e)
        {
            delColumnPane1.ControlReLoad();
        }

        /// <summary>
        /// 加载机台缸
        /// </summary>
        private void LoadDevicePot()
        {
            //DS_PotDAL potDAL = new DS_PotDAL();
            //List<View_DeviceInfoModel> potList = potDAL.GetPotListByType(2);//获取所有缸信息

            //if (potList.Count > 0)
            //{
            //    int groupBoxWidth = panelTop.Width / potList.Count;
            //    foreach (View_DeviceInfoModel potModel in potList)
            //    {

            //        CabinetListen cabinetListen = new CabinetListen(potModel.PotCode, potModel.Id.ToString());
            //        GroupBox gb = cabinetListen.GetCabientInfo(groupBoxWidth + 1, DockStyle.Left, potModel.PotCode, potModel.PotName);
            //        gb.Text = Environment.NewLine + potModel.PotName;
            //        gb.ForeColor = Color.White;
            //        gb.Font = new System.Drawing.Font("宋体",9, FontStyle.Bold);
            //        gb.Padding = new System.Windows.Forms.Padding(2, 20, 2, 5);
            //        gb.Tag = potModel.PotCode;
            //        panelAlarm.Controls.Add(gb);
            //        gb.BringToFront();
            //    }
            //}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            delColumnPane1.ControlReLoad();
        }
    }
}
