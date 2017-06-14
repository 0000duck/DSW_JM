
namespace DSMS.DSW.Control.MyControl
{
    partial class DXPager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_PageInfo = new System.Windows.Forms.Label();
            this.txt_PageIndex = new System.Windows.Forms.TextBox();
            this.btn_Last = new MyControl.ButtonEx();
            this.btn_Nxt = new MyControl.ButtonEx();
            this.btn_Pre = new MyControl.ButtonEx();
            this.btn_First = new MyControl.ButtonEx();
            this.SuspendLayout();
            // 
            // lb_PageInfo
            // 
            this.lb_PageInfo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_PageInfo.Location = new System.Drawing.Point(19, 6);
            this.lb_PageInfo.Name = "lb_PageInfo";
            this.lb_PageInfo.Size = new System.Drawing.Size(319, 29);
            this.lb_PageInfo.TabIndex = 0;
            this.lb_PageInfo.Text = "共{0}条记录,每页{1}条,共{2}页";
            this.lb_PageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_PageIndex
            // 
            this.txt_PageIndex.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PageIndex.Location = new System.Drawing.Point(476, 7);
            this.txt_PageIndex.Name = "txt_PageIndex";
            this.txt_PageIndex.Size = new System.Drawing.Size(30, 33);
            this.txt_PageIndex.TabIndex = 2;
            this.txt_PageIndex.Text = "1";
            this.txt_PageIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PageIndex_KeyDown);
            this.txt_PageIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PageIndex_KeyPress);
            // 
            // btn_Last
            // 
            this.btn_Last.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Last.Location = new System.Drawing.Point(571, 4);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Radius = 10;
            this.btn_Last.Size = new System.Drawing.Size(51, 34);
            this.btn_Last.TabIndex = 1;
            this.btn_Last.Text = ">|";
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_Nxt
            // 
            this.btn_Nxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nxt.Location = new System.Drawing.Point(514, 4);
            this.btn_Nxt.Name = "btn_Nxt";
            this.btn_Nxt.Radius = 10;
            this.btn_Nxt.Size = new System.Drawing.Size(51, 34);
            this.btn_Nxt.TabIndex = 1;
            this.btn_Nxt.Text = ">";
            this.btn_Nxt.Click += new System.EventHandler(this.btn_Nxt_Click);
            // 
            // btn_Pre
            // 
            this.btn_Pre.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pre.Location = new System.Drawing.Point(415, 4);
            this.btn_Pre.Name = "btn_Pre";
            this.btn_Pre.Radius = 10;
            this.btn_Pre.Size = new System.Drawing.Size(51, 34);
            this.btn_Pre.TabIndex = 1;
            this.btn_Pre.Text = "<";
            this.btn_Pre.Click += new System.EventHandler(this.btn_Pre_Click);
            // 
            // btn_First
            // 
            this.btn_First.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_First.Location = new System.Drawing.Point(358, 4);
            this.btn_First.Name = "btn_First";
            this.btn_First.Radius = 10;
            this.btn_First.Size = new System.Drawing.Size(51, 34);
            this.btn_First.TabIndex = 1;
            this.btn_First.Text = "|<";
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // DXPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_PageIndex);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Nxt);
            this.Controls.Add(this.btn_Pre);
            this.Controls.Add(this.btn_First);
            this.Controls.Add(this.lb_PageInfo);
            this.Name = "DXPager";
            this.Size = new System.Drawing.Size(650, 41);
            this.Load += new System.EventHandler(this.DXPager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

   
        private System.Windows.Forms.Label lb_PageInfo;
        private ButtonEx btn_First;
        private ButtonEx btn_Pre;
        private ButtonEx btn_Nxt;
        private ButtonEx btn_Last;

        private System.Windows.Forms.TextBox txt_PageIndex;
    
    }
}
