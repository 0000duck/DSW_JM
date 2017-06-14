using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
    public class DS_DSMaterialModel
    {
        #region Model
        private Guid _id;
        private string _code;
        private string _name;
        private bool _distribution1;
        private bool _distribution2;
        private bool _distribution3;
        private decimal? _concentration;
        private string _unit;
        private decimal? _price;
        private DateTime? _entrydate;
        /// <summary>
        /// 
        /// </summary>
        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Code
        {
            set { _code = value; }
            get { return _code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 前处理烧毛
        /// </summary>
        public bool Distribution1
        {
            set { _distribution1 = value; }
            get { return _distribution1; }
        }
        /// <summary>
        /// 前处理氧漂
        /// </summary>
        public bool Distribution2
        {
            set { _distribution2 = value; }
            get { return _distribution2; }
        }
        /// <summary>
        /// 后整理
        /// </summary>
        public bool Distribution3
        {
            set { _distribution3 = value; }
            get { return _distribution3; }
        }
        /// <summary>
        /// 浓度  液体g/L
        /// </summary>
        public decimal? Concentration
        {
            set { _concentration = value; }
            get { return _concentration; }
        }
        /// <summary>
        /// 结算单位
        /// </summary>
        public string Unit
        {
            set { _unit = value; }
            get { return _unit; }
        }
        /// <summary>
        /// 单价   
        /// </summary>
        public decimal? Price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EntryDate
        {
            set { _entrydate = value; }
            get { return _entrydate; }
        }
        #endregion Model

    }
}