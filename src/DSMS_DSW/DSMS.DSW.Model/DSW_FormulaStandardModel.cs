using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
   public partial class DSW_FormulaStandardModel
    {
       public DSW_FormulaStandardModel()
		{}
		#region Model
		private Guid _id;
		private string _name;
		private decimal? _quantity=500M;
		private int? _type;
		private bool _ismanualfeed;
		private string _remark;
		private DateTime? _entrydate;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 0否1是
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
		public DateTime? EntryDate
		{
			set{ _entrydate=value;}
			get{return _entrydate;}
		}
		#endregion Model

	}
}

