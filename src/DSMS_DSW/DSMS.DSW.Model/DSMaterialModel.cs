using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
   public partial class DSMaterialModel
    {

        #region Model
        private int _id;
        private int _parentid;
        private Guid _materialid;
        private string _materialcode;
        private string _materialname;
        private decimal _quantity;
        private decimal? _concentration;
        private int? _sort;
        private int? _status = 0;
        private string _unittype;
        private decimal _unitprice;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ParentId
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid MaterialId
        {
            set { _materialid = value; }
            get { return _materialid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialCode
        {
            set { _materialcode = value; }
            get { return _materialcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialName
        {
            set { _materialname = value; }
            get { return _materialname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Quantity
        {
            set { _quantity = value; }
            get { return _quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Concentration
        {
            set { _concentration = value; }
            get { return _concentration; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Sort
        {
            set { _sort = value; }
            get { return _sort; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UnitType
        {
            set { _unittype = value; }
            get { return _unittype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal UnitPrice
        {
            set { _unitprice = value; }
            get { return _unitprice; }
        }
        #endregion Model
    }
}
