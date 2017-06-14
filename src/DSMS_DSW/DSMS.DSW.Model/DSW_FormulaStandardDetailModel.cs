using System;
using System.Collections.Generic;
using System.Linq;


namespace DSMS.DSW.Models
{
    [Serializable]
    public class DSW_FormulaStandardDetailModel
    {
        public DSW_FormulaStandardDetailModel()
        { }
        #region Model
        private Guid _id;
        private Guid _parentid;
        private int _sort;
        private Guid _dsmaterialid;
        private decimal? _quantity;
        private decimal? _concentration;
        private int? _type;
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 主表Id
        /// </summary>
        public Guid ParentId
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort
        {
            set { _sort = value; }
            get { return _sort; }
        }
        /// <summary>
        /// 物料Id
        /// </summary>
        public Guid DSMaterialId
        {
            set { _dsmaterialid = value; }
            get { return _dsmaterialid; }
        }
        /// <summary>
        /// 物料量
        /// </summary>
        public decimal? Quantity
        {
            set { _quantity = value; }
            get { return _quantity; }
        }
        /// <summary>
        /// 物料浓度
        /// </summary>
        public decimal? Concentration
        {
            set { _concentration = value; }
            get { return _concentration; }
        }
        /// <summary>
        /// 0标准1含染料
        /// </summary>
        public int? Type
        {
            set { _type = value; }
            get { return _type; }
        }
        #endregion Model
    }
}