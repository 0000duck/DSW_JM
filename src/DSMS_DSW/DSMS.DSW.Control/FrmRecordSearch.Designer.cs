namespace DSMS.DSW.Control
{
    partial class FrmRecordSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnBack = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.dataView1 = new DSMS.DSW.Control.MyControl.DataView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryFilterYMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dxPager1 = new DSMS.DSW.Control.MyControl.DXPager();
            this.roundPanel2 = new DSMS.DSW.Control.MyControl.RoundPanel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(202)))), ((int)(((byte)(246)))));
            this.panelTop.BackgroundImage = global::DSMS.DSW.Control.Properties.Resources.Title;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTop.Controls.Add(this.lblDateTime);
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1024, 72);
            this.panelTop.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateTime.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Black;
            this.lblDateTime.Location = new System.Drawing.Point(689, 18);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(200, 40);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "选择日期";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(918, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Radius = 10;
            this.btnBack.Size = new System.Drawing.Size(95, 49);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataView1
            // 
            this.dataView1.AllowUserToAddRows = false;
            this.dataView1.AllowUserToDeleteRows = false;
            this.dataView1.AllowUserToResizeColumns = false;
            this.dataView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.dataView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView1.BackgroundColor = System.Drawing.Color.White;
            this.dataView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DSType,
            this.序号,
            this.BarCode,
            this.Action,
            this.MatId,
            this.MatCode,
            this.MatName,
            this.UnitType,
            this.UnitPrice,
            this.DSQuantity,
            this.RealQuantity,
            this.TotalPrice,
            this.DeviceId,
            this.DeviceName,
            this.PotCode,
            this.PotName,
            this.EntryDate,
            this.EntryFilterYMD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView1.EnableHeadersVisualStyles = false;
            this.dataView1.Font = new System.Drawing.Font("宋体", 10F);
            this.dataView1.Location = new System.Drawing.Point(0, 122);
            this.dataView1.MultiSelect = false;
            this.dataView1.Name = "dataView1";
            this.dataView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataView1.RowHeadersVisible = false;
            this.dataView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataView1.RowTemplate.Height = 28;
            this.dataView1.RowTemplate.ReadOnly = true;
            this.dataView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView1.Size = new System.Drawing.Size(1024, 597);
            this.dataView1.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DSType
            // 
            this.DSType.DataPropertyName = "DSType";
            this.DSType.HeaderText = "DSType";
            this.DSType.Name = "DSType";
            this.DSType.ReadOnly = true;
            this.DSType.Visible = false;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "序号";
            this.序号.FillWeight = 40.60913F;
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.FillWeight = 108.4844F;
            this.BarCode.HeaderText = "配方编号";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Action";
            this.Action.FillWeight = 108.4844F;
            this.Action.HeaderText = "动作";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // MatId
            // 
            this.MatId.DataPropertyName = "MatId";
            this.MatId.HeaderText = "MatId";
            this.MatId.Name = "MatId";
            this.MatId.ReadOnly = true;
            this.MatId.Visible = false;
            // 
            // MatCode
            // 
            this.MatCode.DataPropertyName = "MatCode";
            this.MatCode.HeaderText = "MatCode";
            this.MatCode.Name = "MatCode";
            this.MatCode.ReadOnly = true;
            this.MatCode.Visible = false;
            // 
            // MatName
            // 
            this.MatName.DataPropertyName = "MatName";
            this.MatName.FillWeight = 108.4844F;
            this.MatName.HeaderText = "助剂";
            this.MatName.Name = "MatName";
            this.MatName.ReadOnly = true;
            // 
            // UnitType
            // 
            this.UnitType.DataPropertyName = "UnitType";
            this.UnitType.HeaderText = "单位";
            this.UnitType.Name = "UnitType";
            this.UnitType.ReadOnly = true;
            this.UnitType.Visible = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Visible = false;
            // 
            // DSQuantity
            // 
            this.DSQuantity.DataPropertyName = "DSQuantity";
            this.DSQuantity.FillWeight = 108.4844F;
            this.DSQuantity.HeaderText = "目标量";
            this.DSQuantity.Name = "DSQuantity";
            this.DSQuantity.ReadOnly = true;
            // 
            // RealQuantity
            // 
            this.RealQuantity.DataPropertyName = "RealQuantity";
            this.RealQuantity.FillWeight = 108.4844F;
            this.RealQuantity.HeaderText = "实际量";
            this.RealQuantity.Name = "RealQuantity";
            this.RealQuantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "总价";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Visible = false;
            // 
            // DeviceId
            // 
            this.DeviceId.DataPropertyName = "DeviceId";
            this.DeviceId.HeaderText = "DeviceId";
            this.DeviceId.Name = "DeviceId";
            this.DeviceId.ReadOnly = true;
            this.DeviceId.Visible = false;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "机台";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            this.DeviceName.Visible = false;
            // 
            // PotCode
            // 
            this.PotCode.DataPropertyName = "PotCode";
            this.PotCode.HeaderText = "PotCode";
            this.PotCode.Name = "PotCode";
            this.PotCode.ReadOnly = true;
            this.PotCode.Visible = false;
            // 
            // PotName
            // 
            this.PotName.DataPropertyName = "PotName";
            this.PotName.FillWeight = 108.4844F;
            this.PotName.HeaderText = "机台缸号";
            this.PotName.Name = "PotName";
            this.PotName.ReadOnly = true;
            // 
            // EntryDate
            // 
            this.EntryDate.DataPropertyName = "EntryDate";
            this.EntryDate.FillWeight = 108.4844F;
            this.EntryDate.HeaderText = "入档时间";
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ReadOnly = true;
            // 
            // EntryFilterYMD
            // 
            this.EntryFilterYMD.DataPropertyName = "EntryFilterYMD";
            this.EntryFilterYMD.HeaderText = "EntryFilterYMD";
            this.EntryFilterYMD.Name = "EntryFilterYMD";
            this.EntryFilterYMD.ReadOnly = true;
            this.EntryFilterYMD.Visible = false;
            // 
            // dxPager1
            // 
            this.dxPager1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(202)))), ((int)(((byte)(246)))));
            this.dxPager1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dxPager1.Conditions = "";
            this.dxPager1.DataSource = null;
            this.dxPager1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dxPager1.GridControl = null;
            this.dxPager1.Location = new System.Drawing.Point(0, 719);
            this.dxPager1.Name = "dxPager1";
            this.dxPager1.Order = "";
            this.dxPager1.PageCount = 0;
            this.dxPager1.PageIndex = 1;
            this.dxPager1.PageSize = 0;
            this.dxPager1.PrimayKey = "";
            this.dxPager1.RecordCount = 0;
            this.dxPager1.Size = new System.Drawing.Size(1024, 49);
            this.dxPager1.SqlStr = null;
            this.dxPager1.TabIndex = 2;
            this.dxPager1.TableName = "";
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.Black;
            this.roundPanel2.BarrelText = "历史记录";
            this.roundPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(73)))), ((int)(((byte)(155)))));
            this.roundPanel2.BorderWidth = 2;
            this.roundPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundPanel2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roundPanel2.ForeColor = System.Drawing.Color.White;
            this.roundPanel2.Location = new System.Drawing.Point(0, 72);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Radius = 15;
            this.roundPanel2.RoundeStyle = DSMS.DSW.Control.MyControl.RoundPanel.RoundStyle.Top;
            this.roundPanel2.Size = new System.Drawing.Size(1024, 50);
            this.roundPanel2.TabIndex = 8;
            // 
            // FrmRecordSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.dataView1);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.dxPager1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecordSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecordSearch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRecordSearch_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private MyControl.DXPager dxPager1;
        private MyControl.DataView dataView1;
        private MyControl.ButtonEx btnBack;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSType;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryFilterYMD;
        private MyControl.RoundPanel roundPanel2;
    }
}