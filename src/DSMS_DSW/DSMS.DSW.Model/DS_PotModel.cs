using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
    public class DS_PotModel
    {

     /// <summary>
	/// DS_Pot:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
 
		public DS_PotModel()
		{}
		#region Model
		private Guid _id;
		private string _potcode;
		private string _potname;
		private string _alarmaddress;
		private string _leveladdress;
		private Guid _deviceid;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PotCode
		{
			set{ _potcode=value;}
			get{return _potcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PotName
		{
			set{ _potname=value;}
			get{return _potname;}
		}
		/// <summary>
		/// 报价地址
		/// </summary>
		public string AlarmAddress
		{
			set{ _alarmaddress=value;}
			get{return _alarmaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LevelAddress
		{
			set{ _leveladdress=value;}
			get{return _leveladdress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid DeviceId
		{
			set{ _deviceid=value;}
			get{return _deviceid;}
		}
		#endregion Model

	}
}

