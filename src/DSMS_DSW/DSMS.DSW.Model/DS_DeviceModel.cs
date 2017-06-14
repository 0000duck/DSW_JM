using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
   public class DS_DeviceModel
    {

       public DS_DeviceModel()
		{}
		#region Model
		private Guid _id;
		private string _code;
		private string _name;
		private string _ip;
		private decimal? _standardquantity;
		private int _type;
		private DateTime _entrydate;
		/// <summary>
		/// Id
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 编号
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// IP
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 标准量
		/// </summary>
		public decimal? StandardQuantity
		{
			set{ _standardquantity=value;}
			get{return _standardquantity;}
		}
		/// <summary>
		/// 1烧毛2氧漂3后整理
		/// </summary>
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 入档时间
		/// </summary>
		public DateTime EntryDate
		{
			set{ _entrydate=value;}
			get{return _entrydate;}
		}
		#endregion Model

	}
}


