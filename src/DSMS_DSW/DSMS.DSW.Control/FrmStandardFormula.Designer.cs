namespace DSMS.DSW.Control
{
    partial class FrmStandardFormula
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBack = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.panelView = new System.Windows.Forms.Panel();
            this.dataView1 = new DSMS.DSW.Control.MyControl.DataView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundPanel2 = new DSMS.DSW.Control.MyControl.RoundPanel();
            this.ViewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viewdata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelView.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(1024, 72);
            this.panelTop.TabIndex = 2;
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
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.White;
            this.panelView.Controls.Add(this.dataView1);
            this.panelView.Controls.Add(this.panel1);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 122);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1024, 646);
            this.panelView.TabIndex = 8;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewId,
            this.ViewName,
            this.Viewdata,
            this.EntryDate});
            this.dataView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView1.EnableHeadersVisualStyles = false;
            this.dataView1.Location = new System.Drawing.Point(0, 0);
            this.dataView1.MultiSelect = false;
            this.dataView1.Name = "dataView1";
            this.dataView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 11F);
            this.dataView1.RowTemplate.Height = 32;
            this.dataView1.RowTemplate.ReadOnly = true;
            this.dataView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView1.Size = new System.Drawing.Size(1024, 586);
            this.dataView1.TabIndex = 9;
            this.dataView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataView1_RowPostPaint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 60);
            this.panel1.TabIndex = 8;
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.Black;
            this.roundPanel2.BarrelText = "标准配方";
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
            this.roundPanel2.TabIndex = 7;
            // 
            // ViewId
            // 
            this.ViewId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ViewId.DataPropertyName = "Id";
            this.ViewId.HeaderText = "Id";
            this.ViewId.Name = "ViewId";
            this.ViewId.ReadOnly = true;
            this.ViewId.Visible = false;
            this.ViewId.Width = 500;
            // 
            // ViewName
            // 
            this.ViewName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ViewName.DataPropertyName = "Name";
            this.ViewName.FillWeight = 187.6794F;
            this.ViewName.HeaderText = "配方名称";
            this.ViewName.Name = "ViewName";
            this.ViewName.ReadOnly = true;
            this.ViewName.Width = 200;
            // 
            // Viewdata
            // 
            this.Viewdata.DataPropertyName = "data";
            this.Viewdata.FillWeight = 0.5173368F;
            this.Viewdata.HeaderText = "助剂明细";
            this.Viewdata.Name = "Viewdata";
            this.Viewdata.ReadOnly = true;
            // 
            // EntryDate
            // 
            this.EntryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EntryDate.DataPropertyName = "EntryDate";
            this.EntryDate.FillWeight = 9.518994F;
            this.EntryDate.HeaderText = "入档日期";
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ReadOnly = true;
            // 
            // FrmStandardFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStandardFormula";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlarmAndQueue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAlarmAndQueue_Load);
            this.panelTop.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private MyControl.ButtonEx btnBack;
        private MyControl.RoundPanel roundPanel2;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panel1;
        private MyControl.DataView dataView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viewdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
    }
}