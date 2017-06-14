namespace DSMS.DSW.Control
{
    partial class FrmMonthCalendar
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
            this.ucDateTimePicker1 = new DSMS.DSW.Control.MyControl.UCDateTimePicker();
            this.SuspendLayout();
            // 
            // ucDateTimePicker1
            // 
            this.ucDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.ucDateTimePicker1.Location = new System.Drawing.Point(45, 8);
            //this.ucDateTimePicker1.Month = 9;
            this.ucDateTimePicker1.Name = "ucDateTimePicker1";
            //this.ucDateTimePicker1.SelectedDay = 8;
            this.ucDateTimePicker1.Size = new System.Drawing.Size(560, 420);
            this.ucDateTimePicker1.TabIndex = 0;
            this.ucDateTimePicker1.Value = new System.DateTime(((long)(0)));
            //this.ucDateTimePicker1.Year = 2016;
            // 
            // FrmMonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 438);
            this.ControlBox = false;
            this.Controls.Add(this.ucDateTimePicker1);
            this.Name = "FrmMonthCalendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMonthCalendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControl.UCDateTimePicker ucDateTimePicker1;

    }
}