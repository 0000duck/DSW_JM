using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSMS.DSW.Control.MyControl
{
    public partial class UCDateTimePicker : UserControl
    {
        public UCDateTimePicker()
        {
            InitializeComponent();
            Init();
        }

        public EventHandler Click;
        public EventHandler DoubleClick;
        

        public DateTime Value { get; set; }
        private int _year;
        private int Year
        {

            get {
                return _year;
            }
            set {
                _year = value;
            }
        
        }

        private int _month ;
        private int Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
                GetMonthCalendar();
            }
        }

        private int _selectedday;

        public int SelectedDay 
        {
            get
            {
                return _selectedday;
            }
            set
            {
                _selectedday = value;
                for (int i = 0; i < dataView1.RowCount; i++)
                {

                    for (int j = 0; j < dataView1.ColumnCount; j++)
                    {
                        if (dataView1.Rows[i].Cells[j].Value.ToString() == _selectedday.ToString("00"))
                        {
                            dataView1.Rows[i].Cells[j].Selected =true;

                        }
                    }
                }

            }
        
        }


        private void UCDateTimePicker_Load(object sender, EventArgs e)
        {
            SelectedDay = DateTime.Now.Day;
        }

        private void GetMonthCalendar()
        {

            lblSelectedMonth.Text = Year+ "年"+Month.ToString("00")+"月";

            DataTable dt = new DataTable();
            string[] Columns = new string[] { "周日", "周一", "周二", "周三", "周四", "周五", "周六" };
            foreach (string str in Columns)
            {
                 
                DataColumn dc = new DataColumn();
                dc.ColumnName = str;
                dt.Columns.Add(dc);

            }
            for (int r = 0; r < 5; r++)
            {
                dt.Rows.Add(dt.NewRow());

            }



            int count = 0;
            int weekvalue = Convert.ToInt16(DateTime.Parse(DateTime.Now.ToString(Year + "年" + Month + "月01日")).DayOfWeek);
            int days = DateTime.DaysInMonth(Year, Month);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i > 0) weekvalue = 0;
                for (int j = weekvalue; j < dt.Columns.Count; j++)
                {
                    count++;
                    if (count <= days)
                        dt.Rows[i][j] = count.ToString("00");
                }
            }

             dataView1.DataSource = dt;
             for(int c=0 ;c<dataView1.ColumnCount;c++)
            {
                dataView1.Columns[c].SortMode =  DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void Init()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            lblToday.Text = DateTime.Now.ToString("今天:yyyy年MM月dd日");
        }

        private void panelLeft_Click(object sender, EventArgs e)
        {

            if (Month > 1)
            {
                Month--;
            }
            else {
                Year--;
                Month = 12;
            }

        }

        private void panelRight_Click(object sender, EventArgs e)
        {
            if (Month < 12)
            {
                Month++;
            }
            else {
                Year++;
                Month = 1;
            }
        }

        private void dataView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string celltext = dataView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!string.IsNullOrEmpty(celltext))
                {

                    Value = DateTime.Parse(Year + "-" + Month + "-" + celltext);
                    Click(Value, null);//单击事件
                }
            }
           
        }

        private void dataView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string celltext = dataView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (!string.IsNullOrEmpty(celltext))
            {
                Value = DateTime.Parse(Year + "-" + Month + "-" + celltext);
                DoubleClick(Value, null);//双击事件
            }

        }

        private void lblToday_Click(object sender, EventArgs e)
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            SelectedDay = DateTime.Now.Day;
        }

       
    }
}
