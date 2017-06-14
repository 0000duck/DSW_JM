using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
   public class View_FormulaDetailInfoModel
    {

        public View_FormulaDetailInfoModel()
		{}
		#region Model
		private Guid _id;
		private string _barcode;
		private Guid _materialid;
		private string _materialname;
		private string _materialcode;
		private decimal _materialquantity;
		private int _sort;
		private string _unit;
		private decimal? _price;
		private Guid _deviceid;
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
		public Guid MaterialId
		{
			set{ _materialid=value;}
			get{return _materialid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MaterialName
		{
			set{ _materialname=value;}
			get{return _materialname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MaterialCode
		{
			set{ _materialcode=value;}
			get{return _materialcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MaterialQuantity
		{
			set{ _materialquantity=value;}
			get{return _materialquantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid DeviceId
		{
			set{ _deviceid=value;}
			get{return _deviceid;}
		}
		#endregion Model

	}
}

