using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
   public class View_DeviceInfoModel
    {
        #region Model
        private Guid _id;
        private int _type;
        private string _potcode;
        private string _potname;
        private string _alarmaddress;
        private string _leveladdress;
        private Guid _deviceid;
        private string _devicecode;
        private string _devicename;
        private string _ip;
        private decimal? _standardquantity;
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
        public int Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PotCode
        {
            set { _potcode = value; }
            get { return _potcode; }
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
        public string AlarmAddress
        {
            set { _alarmaddress = value; }
            get { return _alarmaddress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LevelAddress
        {
            set { _leveladdress = value; }
            get { return _leveladdress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid DeviceId
        {
            set { _deviceid = value; }
            get { return _deviceid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeviceCode
        {
            set { _devicecode = value; }
            get { return _devicecode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeviceName
        {
            set { _devicename = value; }
            get { return _devicename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IP
        {
            set { _ip = value; }
            get { return _ip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? StandardQuantity
        {
            set { _standardquantity = value; }
            get { return _standardquantity; }
        }
        #endregion Model

    }
}
