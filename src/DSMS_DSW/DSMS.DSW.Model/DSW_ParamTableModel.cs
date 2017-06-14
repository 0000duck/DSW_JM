using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
  public  class DSW_ParamTableModel
    {
      public DSW_ParamTableModel()
		{}
		#region Model
		private int _id;
		private string _labelname;
		private string _kepaddress;
		private string _rw;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LabelName
		{
			set{ _labelname=value;}
			get{return _labelname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KepAddress
		{
			set{ _kepaddress=value;}
			get{return _kepaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RW
		{
			set{ _rw=value;}
			get{return _rw;}
		}
		#endregion Model

	}
}


