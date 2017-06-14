using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSMS.DSW.Control.MyControl
{
   public  class DataView :DataGridView
   {

       public DataView()
       {

           #region DataGridVeiw Style
           //this.Font = new System.Drawing.Font("宋体", 10);//字体
           System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
           System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
           this.AllowUserToAddRows = false;
           this.AllowUserToDeleteRows = false;
           dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(231, 232, 239);
           this.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
           this.BackgroundColor = System.Drawing.Color.White;
           this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
           this.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
           dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
           //dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(223, 235, 248);
           dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(0xE7, 0xE8, 0xEF);
           dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 14);//列头字体
           dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
           dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
           dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
           dataGridViewCellStyle2.Padding = new Padding(0,5,0,5);
         
           this.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
           this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.EnableHeadersVisualStyles = false;
           this.GridColor = System.Drawing.SystemColors.ControlDark;
           this.ReadOnly = true;
           this.RowHeadersVisible = true;
           this.RowTemplate.Height = 28;
           this.RowTemplate.ReadOnly = true;
           this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           this.MultiSelect = false;
           this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
           this.AllowUserToResizeRows = false;
           this.AllowUserToResizeColumns = false;
           this.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(231, 232, 239);
           this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
           #endregion

       }

   
   }
}
