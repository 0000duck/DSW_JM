using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
  public partial  class DSW_FormulaModel
    {
      public DSW_FormulaModel()
		{}
		#region Model
		private Guid _id;
		private string _code;
		private string _name;
		private Guid _manufactureorderid;
		private string _manufactureordercode;
		private string _customer;
		private string _color;
		private string _productname;
		private string _productspecification;
		private string _productwidth;
		private DateTime? _latestdate;
		private DateTime _entrydate;
		private Guid _entrypersonnel;
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
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public DateTime? LatestDate
		{
			set{ _latestdate=value;}
			get{return _latestdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EntryDate
		{
			set{ _entrydate=value;}
			get{return _entrydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid EntryPersonnel
		{
			set{ _entrypersonnel=value;}
			get{return _entrypersonnel;}
		}
		#endregion Model

	}
}

