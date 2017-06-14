namespace DSMS.DSW.Control
{
    partial class FrmSingleTest
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.cbkEnd = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combMaterial = new System.Windows.Forms.ComboBox();
            this.combPot = new System.Windows.Forms.ComboBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.numPanel1 = new DSMS.DSW.Control.MyControl.NumPanel();
            this.btnEnd = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.btnStart = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.btnBack = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.cbkEnd);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.combMaterial);
            this.panelMain.Controls.Add(this.combPot);
            this.panelMain.Controls.Add(this.txtTarget);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 72);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(950, 201);
            this.panelMain.TabIndex = 5;
            // 
            // cbkEnd
            // 
            this.cbkEnd.AutoSize = true;
            this.cbkEnd.Checked = true;
            this.cbkEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkEnd.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbkEnd.ForeColor = System.Drawing.Color.Blue;
            this.cbkEnd.Location = new System.Drawing.Point(673, 142);
            this.cbkEnd.Name = "cbkEnd";
            this.cbkEnd.Size = new System.Drawing.Size(15, 14);
            this.cbkEnd.TabIndex = 26;
            this.cbkEnd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(496, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "末端排放";
            // 
            // combMaterial
            // 
            this.combMaterial.DropDownHeight = 500;
            this.combMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combMaterial.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Bold);
            this.combMaterial.FormattingEnabled = true;
            this.combMaterial.IntegralHeight = false;
            this.combMaterial.Location = new System.Drawing.Point(673, 36);
            this.combMaterial.Name = "combMaterial";
            this.combMaterial.Size = new System.Drawing.Size(218, 45);
            this.combMaterial.TabIndex = 5;
            // 
            // combPot
            // 
            this.combPot.DropDownHeight = 500;
            this.combPot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combPot.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Bold);
            this.combPot.FormattingEnabled = true;
            this.combPot.IntegralHeight = false;
            this.combPot.Location = new System.Drawing.Point(243, 36);
            this.combPot.Name = "combPot";
            this.combPot.Size = new System.Drawing.Size(218, 45);
            this.combPot.TabIndex = 4;
            // 
            // txtTarget
            // 
            this.txtTarget.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Bold);
            this.txtTarget.Location = new System.Drawing.Point(243, 126);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(218, 50);
            this.txtTarget.TabIndex = 3;
            this.txtTarget.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(66, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "配送目标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(496, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "助剂名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "机台缸号";
            // 
            // panelBottom
            // 
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnEnd);
            this.panelBottom.Controls.Add(this.btnStart);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 342);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(950, 98);
            this.panelBottom.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 69);
            this.panel1.TabIndex = 6;
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
            this.panelTop.Size = new System.Drawing.Size(950, 72);
            this.panelTop.TabIndex = 3;
            // 
            // numPanel1
            // 
            this.numPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPanel1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numPanel1.Location = new System.Drawing.Point(0, 0);
            this.numPanel1.Name = "numPanel1";
            this.numPanel1.Size = new System.Drawing.Size(950, 69);
            this.numPanel1.TabIndex = 0;
            this.numPanel1.Value = null;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Enabled = false;
            this.btnEnd.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnd.Location = new System.Drawing.Point(514, 25);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Radius = 10;
            this.btnEnd.Size = new System.Drawing.Size(150, 60);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "结束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(330, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Radius = 10;
            this.btnStart.Size = new System.Drawing.Size(150, 60);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(844, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Radius = 10;
            this.btnBack.Size = new System.Drawing.Size(95, 49);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "退出";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmSingleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 440);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(956, 468);
            this.MinimumSize = new System.Drawing.Size(956, 468);
            this.Name = "FrmSingleTest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单步测试";
            this.Load += new System.EventHandler(this.FrmSingleTest_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private MyControl.ButtonEx btnBack;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.ComboBox combMaterial;
        private System.Windows.Forms.ComboBox combPot;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MyControl.NumPanel numPanel1;
        private MyControl.ButtonEx btnEnd;
        private MyControl.ButtonEx btnStart;
        private System.Windows.Forms.CheckBox cbkEnd;
        private System.Windows.Forms.Label label4;
    }
}