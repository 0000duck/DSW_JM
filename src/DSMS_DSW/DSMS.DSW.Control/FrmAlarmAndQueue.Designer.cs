namespace DSMS.DSW.Control
{
    partial class FrmAlarmAndQueue
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBack = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.panelView = new System.Windows.Forms.Panel();
            this.delColumnPane1 = new DSMS.DSW.Control.MyControl.DelColumnPane();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReLoad = new DSMS.DSW.Control.MyControl.ButtonEx();
            this.roundPanel2 = new DSMS.DSW.Control.MyControl.RoundPanel();
            this.panelTop.SuspendLayout();
            this.panelView.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panelView.Controls.Add(this.delColumnPane1);
            this.panelView.Controls.Add(this.panel1);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 122);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1024, 646);
            this.panelView.TabIndex = 8;
            // 
            // delColumnPane1
            // 
            this.delColumnPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delColumnPane1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delColumnPane1.LabelBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delColumnPane1.LabelForeColor = System.Drawing.Color.Empty;
            this.delColumnPane1.Location = new System.Drawing.Point(0, 0);
            this.delColumnPane1.Name = "delColumnPane1";
            this.delColumnPane1.Size = new System.Drawing.Size(1024, 586);
            this.delColumnPane1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(203)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.btnReLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 60);
            this.panel1.TabIndex = 8;
            // 
            // btnReLoad
            // 
            this.btnReLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReLoad.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReLoad.Location = new System.Drawing.Point(917, 6);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Radius = 10;
            this.btnReLoad.Size = new System.Drawing.Size(95, 49);
            this.btnReLoad.TabIndex = 2;
            this.btnReLoad.Text = "刷新";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.Black;
            this.roundPanel2.BarrelText = "请求配送队列";
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
            // FrmAlarmAndQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlarmAndQueue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlarmAndQueue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAlarmAndQueue_Load);
            this.panelTop.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private MyControl.ButtonEx btnBack;
        private MyControl.RoundPanel roundPanel2;
        private System.Windows.Forms.Panel panelView;
        private MyControl.DelColumnPane delColumnPane1;
        private System.Windows.Forms.Panel panel1;
        private MyControl.ButtonEx btnReLoad;
    }
}