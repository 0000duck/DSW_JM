namespace DSMS.DSW.Control
{
    partial class FrmMaterialEdit
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
            this.combMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnSure = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.btnCancel = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPanel1 = new DSMS.DSW.Control.MyControl.NumPanel();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // combMaterial
            // 
            this.combMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combMaterial.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combMaterial.FormattingEnabled = true;
            this.combMaterial.Location = new System.Drawing.Point(177, 29);
            this.combMaterial.Name = "combMaterial";
            this.combMaterial.Size = new System.Drawing.Size(244, 45);
            this.combMaterial.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 32;
            this.label1.Text = "助剂名称";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnSure);
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 178);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(914, 72);
            this.panelBottom.TabIndex = 34;
            // 
            // btnSure
            // 
            this.btnSure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSure.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSure.Location = new System.Drawing.Point(314, 9);
            this.btnSure.Name = "btnSure";
            this.btnSure.Radius = 10;
            this.btnSure.Size = new System.Drawing.Size(120, 55);
            this.btnSure.TabIndex = 30;
            this.btnSure.Text = "确定";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(491, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 10;
            this.btnCancel.Size = new System.Drawing.Size(120, 55);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTarget.Location = new System.Drawing.Point(575, 26);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(289, 50);
            this.txtTarget.TabIndex = 35;
            this.txtTarget.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(446, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 35);
            this.label2.TabIndex = 36;
            this.label2.Text = "目标量";
            // 
            // numPanel1
            // 
            this.numPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numPanel1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numPanel1.Location = new System.Drawing.Point(0, 98);
            this.numPanel1.Name = "numPanel1";
            this.numPanel1.Size = new System.Drawing.Size(914, 80);
            this.numPanel1.TabIndex = 28;
            this.numPanel1.Value = null;
            // 
            // FrmMaterialEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 250);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.numPanel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.combMaterial);
            this.Controls.Add(this.label1);
            this.Name = "FrmMaterialEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "助剂操作";
            this.Load += new System.EventHandler(this.FrmMaterialEdit_Load);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControl.ButtonEx btnSure;
        private MyControl.ButtonEx btnCancel;
        private MyControl.NumPanel numPanel1;
        private System.Windows.Forms.ComboBox combMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label label2;

    }
}