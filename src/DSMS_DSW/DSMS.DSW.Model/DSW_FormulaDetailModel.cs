using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
    public partial class DSW_FormulaDetailModel
    {

        public DSW_FormulaDetailModel()
		{}
		#region Model
		private Guid _id;
		private string _barcode;
		private Guid _parentid;
		private Guid _deviceid;
		private Guid _formulastandardid;
		private decimal _quantity;
		private int _cylindernum;
		private int? _sort;
		private int? _status;
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
		public Guid ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
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
		public Guid FormulaStandardId
		{
			set{ _formulastandardid=value;}
			get{return _formulastandardid;}
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
		public int CylinderNum
		{
			set{ _cylindernum=value;}
			get{return _cylindernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}

        //public List<View_FormulaDetailInfoModel> list
        //{
        //    get;
        //    set;
        //}
		#endregion Model

	}
}

