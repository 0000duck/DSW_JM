namespace DSMS.DSW.Control
{
    partial class FrmSelectFormula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.btnSave = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.btnAdd = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.comboPot = new System.Windows.Forms.ComboBox();
            this.combStandard = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnSure = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.lblStandardQuantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBack = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.dataView1 = new DSMS.DSW.Control.MyControl.DataView();
            this.MaterialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.删除 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panelSelect.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelect
            // 
            this.panelSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSelect.Controls.Add(this.btnSave);
            this.panelSelect.Controls.Add(this.btnAdd);
            this.panelSelect.Controls.Add(this.comboPot);
            this.panelSelect.Controls.Add(this.combStandard);
            this.panelSelect.Controls.Add(this.label2);
            this.panelSelect.Controls.Add(this.label1);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelect.Location = new System.Drawing.Point(0, 72);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(1024, 79);
            this.panelSelect.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(891, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(120, 55);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存配方";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(754, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(120, 55);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboPot
            // 
            this.comboPot.DropDownHeight = 500;
            this.comboPot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPot.DropDownWidth = 220;
            this.comboPot.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboPot.FormattingEnabled = true;
            this.comboPot.IntegralHeight = false;
            this.comboPot.Location = new System.Drawing.Point(510, 20);
            this.comboPot.Name = "comboPot";
            this.comboPot.Size = new System.Drawing.Size(220, 37);
            this.comboPot.TabIndex = 6;
            this.comboPot.SelectedIndexChanged += new System.EventHandler(this.comboDevice_SelectedIndexChanged);
            // 
            // combStandard
            // 
            this.combStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStandard.DropDownWidth = 350;
            this.combStandard.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combStandard.FormattingEnabled = true;
            this.combStandard.Location = new System.Drawing.Point(143, 21);
            this.combStandard.Name = "combStandard";
            this.combStandard.Size = new System.Drawing.Size(220, 37);
            this.combStandard.TabIndex = 5;
            this.combStandard.SelectedIndexChanged += new System.EventHandler(this.combStandard_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(373, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "机台缸号 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "标准配方";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(202)))), ((int)(((byte)(246)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnSure);
            this.panelBottom.Controls.Add(this.lblStandardQuantity);
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 693);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1024, 75);
            this.panelBottom.TabIndex = 5;
            // 
            // btnSure
            // 
            this.btnSure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSure.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSure.Location = new System.Drawing.Point(890, 9);
            this.btnSure.Name = "btnSure";
            this.btnSure.Radius = 10;
            this.btnSure.Size = new System.Drawing.Size(120, 55);
            this.btnSure.TabIndex = 5;
            this.btnSure.Text = "配送";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // lblStandardQuantity
            // 
            this.lblStandardQuantity.BackColor = System.Drawing.Color.White;
            this.lblStandardQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStandardQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStandardQuantity.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStandardQuantity.Location = new System.Drawing.Point(167, 20);
            this.lblStandardQuantity.Name = "lblStandardQuantity";
            this.lblStandardQuantity.Size = new System.Drawing.Size(160, 40);
            this.lblStandardQuantity.TabIndex = 5;
            this.lblStandardQuantity.Text = "0";
            this.lblStandardQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStandardQuantity.Click += new System.EventHandler(this.lblStandardQuantity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(14, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "机台缸量";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(202)))), ((int)(((byte)(246)))));
            this.panelTop.BackgroundImage = global::DSMS.DSW.Control.Properties.Resources.Title;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1024, 72);
            this.panelTop.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(917, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Radius = 10;
            this.btnBack.Size = new System.Drawing.Size(95, 49);
            this.btnBack.TabIndex = 2;
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
            this.MaterialId,
            this.MaterialCode,
            this.MaterialName,
            this.MaterialQuantity,
            this.Unit,
            this.Price,
            this.修改,
            this.删除});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView1.EnableHeadersVisualStyles = false;
            this.dataView1.Font = new System.Drawing.Font("宋体", 10F);
            this.dataView1.Location = new System.Drawing.Point(0, 151);
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
            this.dataView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dataView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataView1.RowTemplate.Height = 28;
            this.dataView1.RowTemplate.ReadOnly = true;
            this.dataView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataView1.Size = new System.Drawing.Size(1024, 542);
            this.dataView1.TabIndex = 4;
            this.dataView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView1_CellContentClick);
            this.dataView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataView1_RowPostPaint);
            // 
            // MaterialId
            // 
            this.MaterialId.DataPropertyName = "MaterialId";
            this.MaterialId.HeaderText = "MaterialId";
            this.MaterialId.Name = "MaterialId";
            this.MaterialId.ReadOnly = true;
            this.MaterialId.Visible = false;
            // 
            // MaterialCode
            // 
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "助剂编号";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "助剂名称";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // MaterialQuantity
            // 
            this.MaterialQuantity.DataPropertyName = "MaterialQuantity";
            this.MaterialQuantity.HeaderText = "目标量";
            this.MaterialQuantity.Name = "MaterialQuantity";
            this.MaterialQuantity.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "单位";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "单价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // 修改
            // 
            this.修改.HeaderText = "修改";
            this.修改.Name = "修改";
            this.修改.ReadOnly = true;
            this.修改.Text = "修改";
            this.修改.UseColumnTextForLinkValue = true;
            // 
            // 删除
            // 
            this.删除.HeaderText = "删除";
            this.删除.Name = "删除";
            this.删除.ReadOnly = true;
            this.删除.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.删除.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.删除.Text = "删除";
            this.删除.UseColumnTextForLinkValue = true;
            // 
            // FrmSelectFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.dataView1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSelectFormula";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectFormula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSelectFormula_Load);
            this.panelSelect.ResumeLayout(false);
            this.panelSelect.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private MyControl.ButtonEx btnBack;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPot;
        private System.Windows.Forms.ComboBox combStandard;
        private MyControl.ButtonEx btnSure;
        private MyControl.ButtonEx btnAdd;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStandardQuantity;
        private MyControl.ButtonEx btnSave;
        private System.Windows.Forms.DataGridViewLinkColumn 删除;
        private System.Windows.Forms.DataGridViewLinkColumn 修改;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialId;
        private MyControl.DataView dataView1;
    }
}