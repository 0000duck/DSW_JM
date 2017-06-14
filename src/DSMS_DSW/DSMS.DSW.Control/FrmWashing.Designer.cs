namespace DSMS.DSW.Control
{
    partial class FrmWashing
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
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAlarm = new System.Windows.Forms.Panel();
            this.lblMaterialQuantity = new DSMS.DSW.Control.MyControl.TLabel();
            this.lblCabinetWaterQuantity = new DSMS.DSW.Control.MyControl.TLabel();
            this.lblPotName = new DSMS.DSW.Control.MyControl.TLabel();
            this.lblCabinetTotal = new DSMS.DSW.Control.MyControl.TLabel();
            this.lblDSQuantity = new DSMS.DSW.Control.MyControl.TLabel();
            this.lblAction = new DSMS.DSW.Control.MyControl.TLabel();
            this.dataView1 = new DSMS.DSW.Control.MyControl.DataView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dataView1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(354, 83);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(689, 559);
            this.panelRight.TabIndex = 60;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.lblMaterialQuantity);
            this.panelMain.Controls.Add(this.lblCabinetWaterQuantity);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.lblPotName);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.lblCabinetTotal);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.lblDSQuantity);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.lblAction);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 83);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(354, 559);
            this.panelMain.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "机台水量:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(27, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 70;
            this.label8.Text = "皂洗剂量:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 68;
            this.label1.Text = "机台缸号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "当前动作:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(27, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 24);
            this.label9.TabIndex = 64;
            this.label9.Text = "实际总量:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "助剂实际:";
            // 
            // panelAlarm
            // 
            this.panelAlarm.BackColor = System.Drawing.Color.Black;
            this.panelAlarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlarm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlarm.Location = new System.Drawing.Point(0, 0);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(1043, 83);
            this.panelAlarm.TabIndex = 64;
            // 
            // lblMaterialQuantity
            // 
            this.lblMaterialQuantity.BackColor = System.Drawing.Color.Black;
            this.lblMaterialQuantity.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMaterialQuantity.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMaterialQuantity.Location = new System.Drawing.Point(25, 393);
            this.lblMaterialQuantity.Name = "lblMaterialQuantity";
            this.lblMaterialQuantity.Size = new System.Drawing.Size(300, 50);
            this.lblMaterialQuantity.TabIndex = 73;
            this.lblMaterialQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCabinetWaterQuantity
            // 
            this.lblCabinetWaterQuantity.BackColor = System.Drawing.Color.Black;
            this.lblCabinetWaterQuantity.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCabinetWaterQuantity.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCabinetWaterQuantity.Location = new System.Drawing.Point(25, 479);
            this.lblCabinetWaterQuantity.Name = "lblCabinetWaterQuantity";
            this.lblCabinetWaterQuantity.Size = new System.Drawing.Size(300, 50);
            this.lblCabinetWaterQuantity.TabIndex = 72;
            this.lblCabinetWaterQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPotName
            // 
            this.lblPotName.BackColor = System.Drawing.Color.Black;
            this.lblPotName.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPotName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPotName.Location = new System.Drawing.Point(25, 306);
            this.lblPotName.Name = "lblPotName";
            this.lblPotName.Size = new System.Drawing.Size(300, 50);
            this.lblPotName.TabIndex = 69;
            this.lblPotName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCabinetTotal
            // 
            this.lblCabinetTotal.BackColor = System.Drawing.Color.Black;
            this.lblCabinetTotal.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCabinetTotal.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCabinetTotal.Location = new System.Drawing.Point(26, 219);
            this.lblCabinetTotal.Name = "lblCabinetTotal";
            this.lblCabinetTotal.Size = new System.Drawing.Size(300, 50);
            this.lblCabinetTotal.TabIndex = 65;
            this.lblCabinetTotal.Text = "0.00";
            this.lblCabinetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDSQuantity
            // 
            this.lblDSQuantity.BackColor = System.Drawing.Color.Black;
            this.lblDSQuantity.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDSQuantity.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDSQuantity.Location = new System.Drawing.Point(26, 131);
            this.lblDSQuantity.Name = "lblDSQuantity";
            this.lblDSQuantity.Size = new System.Drawing.Size(300, 50);
            this.lblDSQuantity.TabIndex = 63;
            this.lblDSQuantity.Text = "0.00";
            this.lblDSQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAction
            // 
            this.lblAction.BackColor = System.Drawing.Color.Black;
            this.lblAction.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAction.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAction.Location = new System.Drawing.Point(28, 43);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(300, 50);
            this.lblAction.TabIndex = 66;
            this.lblAction.Text = "xxx";
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataView1
            // 
            this.dataView1.AllowUserToAddRows = false;
            this.dataView1.AllowUserToDeleteRows = false;
            this.dataView1.AllowUserToResizeColumns = false;
            this.dataView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.PotName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView1.EnableHeadersVisualStyles = false;
            this.dataView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataView1.GridColor = System.Drawing.Color.White;
            this.dataView1.Location = new System.Drawing.Point(0, 0);
            this.dataView1.MultiSelect = false;
            this.dataView1.Name = "dataView1";
            this.dataView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataView1.RowHeadersWidth = 50;
            this.dataView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataView1.RowTemplate.Height = 28;
            this.dataView1.RowTemplate.ReadOnly = true;
            this.dataView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView1.Size = new System.Drawing.Size(689, 559);
            this.dataView1.TabIndex = 32;
            this.dataView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataView1_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ActionName";
            this.dataGridViewTextBoxColumn2.HeaderText = "动作";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaterialName";
            this.dataGridViewTextBoxColumn3.HeaderText = "助剂";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DSQuantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "实际量";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EntryDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "时间";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PotName
            // 
            this.PotName.HeaderText = "机台缸号";
            this.PotName.Name = "PotName";
            this.PotName.ReadOnly = true;
            this.PotName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmWashing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1043, 642);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmWashing";
            this.Load += new System.EventHandler(this.FrmWashing_Load);
            this.panelRight.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRight;
        private MyControl.DataView dataView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotName;
        private System.Windows.Forms.Panel panelAlarm;
        private MyControl.TLabel lblMaterialQuantity;
        private MyControl.TLabel lblCabinetWaterQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private MyControl.TLabel lblPotName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyControl.TLabel lblCabinetTotal;
        private System.Windows.Forms.Label label9;
        private MyControl.TLabel lblDSQuantity;
        private System.Windows.Forms.Label label6;
        private MyControl.TLabel lblAction;
    }
}