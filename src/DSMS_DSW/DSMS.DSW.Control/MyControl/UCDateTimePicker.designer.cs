namespace DSMS.DSW.Control.MyControl
{
    partial class UCDateTimePicker
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDateTimePicker));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblSelectedMonth = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblToday = new System.Windows.Forms.Label();
            this.dataView1 = new DSMS.DSW.Control.MyControl.DataView();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblSelectedMonth);
            this.panelTop.Controls.Add(this.panelRight);
            this.panelTop.Controls.Add(this.panelLeft);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(560, 65);
            this.panelTop.TabIndex = 0;
            // 
            // lblSelectedMonth
            // 
            this.lblSelectedMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedMonth.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSelectedMonth.Location = new System.Drawing.Point(100, 0);
            this.lblSelectedMonth.Name = "lblSelectedMonth";
            this.lblSelectedMonth.Size = new System.Drawing.Size(360, 65);
            this.lblSelectedMonth.TabIndex = 2;
            this.lblSelectedMonth.Text = "2015年8月";
            this.lblSelectedMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRight.BackgroundImage")));
            this.panelRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(460, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(100, 65);
            this.panelRight.TabIndex = 1;
            this.panelRight.Click += new System.EventHandler(this.panelRight_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(100, 65);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Click += new System.EventHandler(this.panelLeft_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblToday);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 370);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(560, 50);
            this.panelBottom.TabIndex = 1;
            // 
            // lblToday
            // 
            this.lblToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToday.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblToday.Location = new System.Drawing.Point(0, 0);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(560, 50);
            this.lblToday.TabIndex = 0;
            this.lblToday.Text = "今天:2016年9月8日";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToday.Click += new System.EventHandler(this.lblToday_Click);
            // 
            // dataView1
            // 
            this.dataView1.AllowUserToAddRows = false;
            this.dataView1.AllowUserToDeleteRows = false;
            this.dataView1.AllowUserToResizeColumns = false;
            this.dataView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.dataView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView1.BackgroundColor = System.Drawing.Color.White;
            this.dataView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataView1.ColumnHeadersHeight = 50;
            this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView1.EnableHeadersVisualStyles = false;
            this.dataView1.Font = new System.Drawing.Font("宋体", 10F);
            this.dataView1.Location = new System.Drawing.Point(0, 65);
            this.dataView1.MultiSelect = false;
            this.dataView1.Name = "dataView1";
            this.dataView1.ReadOnly = true;
            this.dataView1.RowHeadersVisible = false;
            this.dataView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataView1.RowTemplate.Height = 50;
            this.dataView1.RowTemplate.ReadOnly = true;
            this.dataView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataView1.Size = new System.Drawing.Size(560, 305);
            this.dataView1.TabIndex = 2;
            this.dataView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView1_CellClick);
            this.dataView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView1_CellDoubleClick);
            // 
            // UCDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dataView1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "UCDateTimePicker";
            this.Size = new System.Drawing.Size(560, 420);
            this.Load += new System.EventHandler(this.UCDateTimePicker_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblSelectedMonth;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblToday;
        private DataView dataView1;
    }
}
