using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
public partial  class DS_RecordModel
    {

        #region Model
        private int _id;
        private int _dstype;
        private string _barcode;
        private string _action;
        private Guid _matid;
        private string _matcode;
        private string _matname;
        private string _unittype;
        private decimal? _unitprice;
        private decimal? _dsquantity;
        private decimal? _realQuantity;
        private decimal? _totalprice;
        private Guid _deviceId;
        private string _deviceName;
        private DateTime? _entrydate;
        private string _entryfilterymd;
        private string _potCode;
        private string _potName;
        /// <summary>
        /// Id
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 类型
        /// </summary>
        public int DSType
        {
            set { _dstype = value; }
            get { return _dstype; }
        }
        /// <summary>
        /// 条码
        /// </summary>
        public string BarCode
        {
            set { _barcode = value; }
            get { return _barcode; }
        }
        /// <summary>
        /// 动作
        /// </summary>
        public string Action
        {
            set { _action = value; }
            get { return _action; }
        }
        /// <summary>
        /// 物料Id
        /// </summary>
        public Guid MatId
        {
            set { _matid = value; }
            get { return _matid; }
        }
        /// <summary>
        /// 物料代码
        /// </summary>
        public string MatCode
        {
            set { _matcode = value; }
            get { return _matcode; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string MatName
        {
            set { _matname = value; }
            get { return _matname; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string UnitType
        {
            set { _unittype = value; }
            get { return _unittype; }
        }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal? UnitPrice
        {
            set { _unitprice = value; }
            get { return _unitprice; }
        }
        /// <summary>
        /// 配送量
        /// </summary>
        public decimal? DSQuantity
        {
            set { _dsquantity = value; }
            get { return _dsquantity; }
        }
        /// <summary>
        /// 实际量
        /// </summary>
        public decimal? RealQuantity
        {
            set { _realQuantity = value; }
            get { return _realQuantity; }
        }
        /// <summary>
        /// 总价
        /// </summary>
        public decimal? TotalPrice
        {
            set { _totalprice = value; }
            get { return _totalprice; }
        }
        /// <summary>
        /// 设备Id
        /// </summary>
        public Guid DeviceId
        {
            set { _deviceId = value; }
            get { return _deviceId; }
        }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName
        {
            set { _deviceName = value; }
            get { return _deviceName; }
        }

        /// <summary>
        /// 缸号
        /// </summary>
        public string PotCode
        {
            set { _potCode = value; }
            get { return _potCode; }
        }
        /// <summary>
        /// 缸名称
        /// </summary>
        public string PotName
        {
            set { _potName = value; }
            get { return _potName; }
        }
        /// <summary>
        /// 入档时间
        /// </summary>
        public DateTime? EntryDate
        {
            set { _entrydate = value; }
            get { return _entrydate; }
        }
        /// <summary>
        /// 过滤条件(天)
        /// </summary>
        public string EntryFilterYMD
        {
            set { _entryfilterymd = value; }
            get { return _entryfilterymd; }
        }
        #endregion Model

    }
}
