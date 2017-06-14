using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DSMS.DSW.Model;
using Simple.Data;

namespace DSMS.DSW.DAL
{
   public partial class DS_RecordDAL
    {


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(DS_RecordModel model)
        {
            try
            {
                string TableName = DateTime.Now.ToString("yyyy");
                if (!AutoCreateDB.IsExistTable(TableName))
                {
                    AutoCreateDB.CreateTable(TableName);
                }
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into dbo.[" + TableName + "](");
                strSql.Append("DSType,BarCode,Action,MatId,MatCode,MatName,UnitType,UnitPrice,DSQuantity,RealQuantity,TotalPrice,DeviceId,DeviceName,PotCode,PotName,EntryDate,EntryFilterYMD)");
                strSql.Append(" values (");
                strSql.Append("@DSType,@BarCode,@Action,@MatId,@MatCode,@MatName,@UnitType,@UnitPrice,@DSQuantity,@RealQuantity,@TotalPrice,@DeviceId,@DeviceName,@PotCode,@PotName,@EntryDate,@EntryFilterYMD)");
                strSql.Append(";select @@IDENTITY");
                SqlParameter[] parameters = {
					new SqlParameter("@DSType", SqlDbType.Int,4),
					new SqlParameter("@BarCode", SqlDbType.NVarChar,50),
					new SqlParameter("@Action", SqlDbType.NVarChar,50),
					new SqlParameter("@MatId", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@MatCode", SqlDbType.NVarChar,50),
					new SqlParameter("@MatName", SqlDbType.NVarChar,50),
					new SqlParameter("@UnitType", SqlDbType.Char,10),
					new SqlParameter("@UnitPrice", SqlDbType.Decimal,9),
					new SqlParameter("@DSQuantity", SqlDbType.Decimal,9),
                    new SqlParameter("@RealQuantity", SqlDbType.Decimal,9),
					new SqlParameter("@TotalPrice", SqlDbType.Decimal,9),
					new SqlParameter("@DeviceId", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@DeviceName", SqlDbType.NVarChar,50),
                    new SqlParameter("@PotCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@PotName", SqlDbType.NVarChar,50),
					new SqlParameter("@EntryDate", SqlDbType.DateTime),
					new SqlParameter("@EntryFilterYMD", SqlDbType.NVarChar,50)};
                parameters[0].Value = model.DSType;
                parameters[1].Value = model.BarCode;
                parameters[2].Value = model.Action;
                parameters[3].Value = model.MatId;
                parameters[4].Value = model.MatCode;
                parameters[5].Value = model.MatName;
                parameters[6].Value = model.UnitType;
                parameters[7].Value = model.UnitPrice;
                parameters[8].Value = model.DSQuantity;
                parameters[9].Value = model.RealQuantity;
                parameters[10].Value = model.TotalPrice;
                parameters[11].Value = model.DeviceId;
                parameters[12].Value = model.DeviceName;
                parameters[13].Value = model.PotCode;
                parameters[14].Value = model.PotName;
                parameters[15].Value = model.EntryDate;
                parameters[16].Value = model.EntryFilterYMD;
                SQLHelper.RunProcPrams(strSql.ToString(), parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public string GetListByDate(DateTime dateTime)
        {

            string TableName = dateTime.ToString("yyyy");
            if (!AutoCreateDB.IsExistTable(TableName))
            {
                AutoCreateDB.CreateTable(TableName);
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,DSType,BarCode,Action,MatId,MatCode,MatName,UnitType,UnitPrice,DSQuantity,RealQuantity,TotalPrice,DeviceId,DeviceName,PotCode,PotName,CONVERT(varchar(100),EntryDate,108)as EntryDate,EntryFilterYMD ");
            strSql.Append(" FROM   dbo.[" + TableName + "]");
            strSql.Append(" where  DSType=2 AND EntryFilterYMD='" + dateTime.ToString("yyyyMMdd") + "' ");

            return strSql.ToString();
        }
    }
}
