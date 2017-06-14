using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
 
using System.Configuration;
using DSMS.DSW.DAL;


namespace DSMS.DSW.Control.MyControl
{
    public delegate void PagedEventHandler(object sender,PagedEventArgs e);
    public partial class DXPager : UserControl
    {
        #region 字段
        private string _tableName = string.Empty;//表名字，视图也可以

        private string _primayKey = string.Empty;//主键字段

        private int _pageSize ;//页面大小        private int _pageSize = 10;

        private int _pageIndex = 1;  //当前页号

        private int _pageCount = 0; //页面数

        private int _recordCount = 0;//总记录数

        private string _Fields = "*";//要查询的字段，以逗号隔开

        private string _conditions = string.Empty;//要查询的条件

        private string _order = string.Empty;//排序规则

        private string  _PageInfo = "共{0}条记录,每页{1}条,共{2}页";
        #endregion

        #region 属性
        [Description("表名或者视图名")]
        [Category("分页属性")]
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        [Description("页面大小")]
        [Category("分页属性")]
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }

        [Description("查询字段")]
        [Category("分页属性")]
        [DefaultValue("*")]
        public string Fields
        {
            get { return _Fields; }
            set { _Fields = value; }
        }

        [Description("主键字段")]
        [Category("分页属性")]
        [DefaultValue("*")]
        public string PrimayKey
        {
            get { return _primayKey; }
            set { _primayKey = value; }
        }

        [Description("查询条件")]
        [Category("分页属性")]
        public string Conditions
        {
            get { return _conditions; }
            set { _conditions = value; }
        }

        [Description("排序规则")]
        [Category("分页属性")]
        public string Order
        {
            get { return _order; }
            set { _order = value; }
        }

        public int PageIndex
        {
            get { return _pageIndex; }
            set { _pageIndex = value; }
        }


        public int PageCount
        {
            get { return _pageCount; }
            set { _pageCount = value; }
        }

        public int RecordCount
        {
            get { return _recordCount; }
            set { _recordCount = value; }
        }

        [Description("GridControl设置")]
        [Category("分页属性")]
        public DataView GridControl
        {
            get;
            set;
        }
        /// <summary>
        /// 分页数据源
        /// </summary>
        public DataTable DataSource
        {
            get;
            set;
        }

        /// <summary>
        /// SQL
        /// </summary>
        public string SqlStr
        {
            get;
            set;
        }
        #endregion

        #region 构造器
        public DXPager()
        {
            InitializeComponent();
           
        }
        #endregion

        private void DXPager_Load(object sender, EventArgs e)
        {
      
            if (this.DesignMode) return;
            //this.cbe_PageSize.SelectedIndexChanged -= new System.EventHandler(this.cbe_PageSize_SelectedIndexChanged);
            //cbe_PageSize.Text = PageSize.ToString() ;
            //this.cbe_PageSize.SelectedIndexChanged += new System.EventHandler(this.cbe_PageSize_SelectedIndexChanged);
            PageSize = 20;
            
        }

        //定义分页事件
        public event PagedEventHandler Paged;
        //绑定控件和数据
        public void DataToBind()
        {
            DataTable dt = SQLHelper.CreateSqlByPageExcuteSql(SqlStr, PageIndex, PageSize, Order, null, ref _recordCount);
            if (dt.Rows.Count== 0)
            {
                _pageIndex = 0;
                _pageCount = 0;
                _recordCount = 0;
            }
            else
            {
                _pageCount = _recordCount % _pageSize == 0 ? _recordCount / _pageSize : _recordCount / _pageSize + 1;
            }
            Bind();
            lb_PageInfo.Text = string.Format(_PageInfo, RecordCount, PageSize, PageCount);
            txt_PageIndex.Text = this.PageIndex.ToString();
            this.DataSource = dt;
            this.GridControl.DataSource = dt;
        }

     
        private void Bind()
        {
            if (this.PageIndex > this.PageCount)
            {
                this.PageIndex = this.PageCount;
            }
            if (this.PageCount > 0 && PageIndex == 0) 
            {
                this.PageIndex = 1;
            }
            if (this.PageCount == 1)
            {
                this.PageIndex = 1;
            }
            if (this.PageIndex == 1)
            {
                this.btn_Pre.Enabled = false;
                this.btn_First.Enabled = false;
            }
            else
            {
                btn_Pre.Enabled = true;
                btn_First.Enabled = true;
            }

            if (this.PageIndex == this.PageCount)
            {
                this.btn_Last.Enabled = false;
                this.btn_Nxt.Enabled = false;
            }
            else
            {
                btn_Last.Enabled = true;
                btn_Nxt.Enabled = true;
            }
            if (RecordCount == 0)
            {
                this.btn_First.Enabled = false;
                this.btn_Pre.Enabled = false;
                this.btn_Nxt.Enabled = false;
                this.btn_Last.Enabled = false;
            }
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            this.PageIndex = 1;
            DataToBind();
            if (Paged != null)
            {
                Paged(this,null);
            }
        }

        private void btn_Pre_Click(object sender, EventArgs e)
        {
            this.PageIndex -= 1;
            if (PageIndex <= 0)
            {
                PageIndex = 1;
            }
            DataToBind();
            if (Paged != null)
            {
                Paged(this,null);
            }
        }

        private void btn_Nxt_Click(object sender, EventArgs e)
        {
            this.PageIndex += 1;
            if (PageIndex > PageCount)
            {
                PageIndex = PageCount;
            }
            DataToBind();
            if (Paged != null)
            {
                Paged(this,null);
            }
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            this.PageIndex = PageCount;
            DataToBind();
            if (Paged != null)
            {
                Paged(this,null);
            }
        }

        private void txt_PageIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled =true;
            }
        }

        private void txt_PageIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int flag = Convert.ToInt32(txt_PageIndex.Text);
                if (flag < 1 || flag > PageCount)
                {

                    if (flag < 1)
                    {
                        PageIndex = 1;
                    }
                    else {
                        PageIndex = PageCount;
                    }
                }
         
                PageIndex = flag > PageCount?PageCount:flag;
                DataToBind();
                if (Paged != null)
                {
                    Paged(this,null);
                }
            }
        }

        //private void cbe_PageSize_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _pageSize =Convert.ToInt32( cbe_PageSize.Text);
        //    _pageIndex = 1;
        //    DataToBind();
        //    if (Paged != null)
        //    {
        //        Paged(this,null);
        //    }
        //}

    

        public void ReLoad()
        {
            this.PageIndex = 1;
            DataToBind();
            if (Paged != null)
            {
                Paged(this, null);
            }

        }
    }


    public class PagedEventArgs : EventArgs
    {
        public PagedEventArgs()
        {

        }
    }
}
