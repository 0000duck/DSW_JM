using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
   public class View_WashingModel
    {
        private Guid _id;
        private string _barcode;
        private decimal _materialquantity;
        private decimal _cabientwaterquantity;
        private Guid _deviceid;
        private string _devicecode;
        private string _devicename;
        private int  _devicetype;
        private string _potcode;


        public Guid Id{
            set{ _id=value;}
			get{return _id;}
         }
        /// <summary>
        /// 自定义编号
        /// </summary>
        public string BarCode
        {
            set { _barcode = value; }
            get { return _barcode; }
        }
       /// <summary>
       /// 助剂(皂洗剂)
       /// </summary>
        public decimal MaterialQuantity
        {
            set { _materialquantity = value; }
            get { return _materialquantity; }
        }
        /// <summary>
        /// 机台水
        /// </summary>
        public decimal CabientWaterQuantity
        {
            set { _cabientwaterquantity = value; }
            get { return _cabientwaterquantity; }
        }

        /// <summary>
        /// 机台Id
        /// </summary>
        public  Guid  DeviceId
        {
            set { _deviceid = value; }
            get { return _deviceid; }
        }

        /// <summary>
        /// 机台编号
        /// </summary>
        public string DeviceCode
        {
            set { _devicecode = value; }
            get { return _devicecode; }
        }

        /// <summary>
        /// 机台名称
        /// </summary>
        public string DeviceName
        {
            set { _devicename = value; }
            get { return _devicename; }
        }

         //<summary>
         //机台类型
         //</summary>
        public int Devicetype
        {
            set { _devicetype = value; }
            get { return _devicetype; }
        }

  
        //<summary>
        //机台缸号
        //</summary>
        public string PotCode
        {
            set { _potcode = value; }
            get { return _potcode; }
        }
  


        public string ClientIP { get; set; }
    }
}
