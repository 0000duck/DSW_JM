using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace DSMS.DSW.Model
{
    public class BarCodeModel
    {
        public BarCodeModel()
		{}
		#region Model
		private Guid _id;
		private string _name;
		private string _day;
		private int _max;
		/// <summary>
		/// Id
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
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
		/// day
		/// </summary>
		public string day
		{
            set { _day = value; }
            get { return _day; }
		}
		 
		/// <summary>
		/// max
		/// </summary>
		public int max
		{
            set { _max = value; }
            get { return _max; }
		}
	 
		#endregion Model
    
    }
}