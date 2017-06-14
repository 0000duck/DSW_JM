using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
   public partial class DSW_FormulaDistributionModel
    {

       public DSW_FormulaDistributionModel()
		{}
		#region Model
		private int _id;
		private string _barcode;
        private string _potname;
		private decimal? _dsquantity;
		private decimal? _realquantity;
		private DateTime? _recordtime;
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
		public string BarCode
		{
			set{ _barcode=value;}
			get{return _barcode;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string PotName
        {
            set { _potname = value; }
            get { return _potname; }
        }

		/// <summary>
		/// 
		/// </summary>
		public decimal? DSQuantity
		{
			set{ _dsquantity=value;}
			get{return _dsquantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RealQuantity
		{
			set{ _realquantity=value;}
			get{return _realquantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RecordTime
		{
			set{ _recordtime=value;}
			get{return _recordtime;}
		}
		#endregion Model

	}
}


