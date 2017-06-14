namespace DSMS.DSW.Control
{
    partial class FrmParamSet
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
            this.dataView1 = new DSMS.DSW.Control.MyControl.DataView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KepAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetValue = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnBack = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(970, 72);
            this.panelTop.TabIndex = 2;
            // 
            // dataView1
            // 
            this.dataView1.AllowUserToAddRows = false;
            this.dataView1.AllowUserToDeleteRows = false;
            this.dataView1.AllowUserToResizeColumns = false;
            this.dataView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView1.BackgroundColor = System.Drawing.Color.White;
            this.dataView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LabelName,
            this.KepAddress,
            this.CurrentValue,
            this.RW,
            this.SetValue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView1.EnableHeadersVisualStyles = false;
            this.dataView1.Font = new System.Drawing.Font("宋体", 14F);
            this.dataView1.Location = new System.Drawing.Point(0, 72);
            this.dataView1.MultiSelect = false;
            this.dataView1.Name = "dataView1";
            this.dataView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 14F);
            this.dataView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dataView1.RowTemplate.Height = 32;
            this.dataView1.RowTemplate.ReadOnly = true;
            this.dataView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataView1.Size = new System.Drawing.Size(970, 563);
            this.dataView1.TabIndex = 3;
            this.dataView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView1_CellContentClick);
            this.dataView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataView1_RowPostPaint);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // LabelName
            // 
            this.LabelName.DataPropertyName = "LabelName";
            this.LabelName.HeaderText = "名称";
            this.LabelName.Name = "LabelName";
            this.LabelName.ReadOnly = true;
            // 
            // KepAddress
            // 
            this.KepAddress.DataPropertyName = "KepAddress";
            this.KepAddress.HeaderText = "地址";
            this.KepAddress.Name = "KepAddress";
            this.KepAddress.ReadOnly = true;
            // 
            // CurrentValue
            // 
            this.CurrentValue.DataPropertyName = "CurrentValue";
            this.CurrentValue.HeaderText = "当前值";
            this.CurrentValue.Name = "CurrentValue";
            this.CurrentValue.ReadOnly = true;
            // 
            // RW
            // 
            this.RW.DataPropertyName = "RW";
            this.RW.HeaderText = "RW";
            this.RW.Name = "RW";
            this.RW.ReadOnly = true;
            this.RW.Visible = false;
            // 
            // SetValue
            // 
            this.SetValue.HeaderText = "修改";
            this.SetValue.Name = "SetValue";
            this.SetValue.ReadOnly = true;
            this.SetValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SetValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SetValue.Text = "修改";
            this.SetValue.UseColumnTextForLinkValue = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(864, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Radius = 10;
            this.btnBack.Size = new System.Drawing.Size(95, 49);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmParamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 635);
            this.Controls.Add(this.dataView1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmParamSet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmParamSet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmParamSet_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private MyControl.ButtonEx btnBack;
        private MyControl.DataView dataView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn KepAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn RW;
        private System.Windows.Forms.DataGridViewLinkColumn SetValue;
    }
}