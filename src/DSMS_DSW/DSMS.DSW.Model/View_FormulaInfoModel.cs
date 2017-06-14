using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
   public partial class View_FormulaInfoModel
    {

       public View_FormulaInfoModel()
		{}
		#region Model
		private Guid _id;
		private string _barcode;
		private decimal _quantity;
        private string _formulaname;
		private int _cylindernum;
		private Guid _deviceid;
        private string _devicecode;
        private string _devicename;
        private int _devicetype;
        private string _potcode;
        private decimal _standardquantity;
		private bool _ismanualfeed;
		private string _remark;
		private Guid _manufactureorderid;
		private string _manufactureordercode;
		private string _customer;
		private string _color;
		private string _productname;
		private string _productspecification;
		private string _productwidth;
		private string _meter;
		private DateTime? _latestdate;
        private int _status;
        private int _completecylindernum;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BarCode
		{
			set{ _barcode=value;}
			get{return _barcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string FormulaName 
        {
            set { _formulaname = value; }
            get { return _formulaname; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int CylinderNum
		{
			set{ _cylindernum=value;}
			get{return _cylindernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid DeviceId
		{
			set{ _deviceid=value;}
			get{return _deviceid;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string DeviceCode
        {
            set { _devicecode = value; }
            get { return _devicecode; }
        }
       	/// <summary>
		/// 
		/// </summary>
        public string DeviceName
		{
            set { _devicename = value; }
            get { return _devicename; }
		}

        /// <summary>
        /// 
        /// </summary>
        public int DeviceType
        {
            set { _devicetype = value; }
            get { return _devicetype; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PotCode
        {
            set { _potcode = value; }
            get { return _potcode; }
        }
        public decimal StandardQuantity
        {
            set { _standardquantity = value; }
            get { return _standardquantity; }
        
        }
		/// <summary>
		/// 
		/// </summary>
		public bool IsManualFeed
		{
			set{ _ismanualfeed=value;}
			get{return _ismanualfeed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid ManufactureOrderId
		{
			set{ _manufactureorderid=value;}
			get{return _manufactureorderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ManufactureOrderCode
		{
			set{ _manufactureordercode=value;}
			get{return _manufactureordercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Customer
		{
			set{ _customer=value;}
			get{return _customer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Color
		{
			set{ _color=value;}
			get{return _color;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductSpecification
		{
			set{ _productspecification=value;}
			get{return _productspecification;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductWidth
		{
			set{ _productwidth=value;}
			get{return _productwidth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Meter
		{
			set{ _meter=value;}
			get{return _meter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LatestDate
		{
			set{ _latestdate=value;}
			get{return _latestdate;}
		}
        /// <summary>
        /// 
        /// </summary>
        public int Status
        {
            set { _status = value; }
            get { return _status; }
        }

        public List<View_FormulaDetailInfoModel> list
        {
            get;
            set;
        }

        public string ClientIP { get; set; }

        public int CompleteCylinderNum {

            set { _completecylindernum = value; }
            get { return _completecylindernum; }
        }
		#endregion Model

	}
}

