namespace DSMS.DSW.Control
{
    partial class FrmDefault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDefault));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelA = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.panelA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(202)))), ((int)(((byte)(246)))));
            this.panelTop.BackgroundImage = global::DSMS.DSW.Control.Properties.Resources.Title;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1018, 72);
            this.panelTop.TabIndex = 0;
            this.panelTop.DoubleClick += new System.EventHandler(this.panelTop_DoubleClick);
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.panelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 72);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1018, 45);
            this.panelButton.TabIndex = 8;
            // 
            // panelA
            // 
            this.panelA.Controls.Add(this.panelB);
            this.panelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelA.Location = new System.Drawing.Point(0, 117);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(1018, 623);
            this.panelA.TabIndex = 9;
            // 
            // panelB
            // 
            this.panelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelB.Location = new System.Drawing.Point(0, 0);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(1018, 623);
            this.panelB.TabIndex = 0;
            // 
            // FrmDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 740);
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmDefault";
            this.Text = "后整理助剂自动配送系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDefault_Load);
            this.panelA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel panelB;
    }
}