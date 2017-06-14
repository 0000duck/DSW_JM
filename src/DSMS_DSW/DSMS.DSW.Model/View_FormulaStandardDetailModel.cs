using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
   public partial class View_FormulaStandardDetailModel
    {

       public View_FormulaStandardDetailModel()
		{}
		#region Model
		private Guid _id;
		private Guid _parentid;
		private Guid _matid;
		private string _matcode;
		private string _matname;
		private decimal? _matquantity;
		private string _unit;
		private decimal? _price;
		private int _sort;
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
		public Guid ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid MatId
		{
			set{ _matid=value;}
			get{return _matid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MatCode
		{
			set{ _matcode=value;}
			get{return _matcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MatName
		{
			set{ _matname=value;}
			get{return _matname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MatQuantity
		{
			set{ _matquantity=value;}
			get{return _matquantity;}
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
		public int Sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		#endregion Model

	}
}


