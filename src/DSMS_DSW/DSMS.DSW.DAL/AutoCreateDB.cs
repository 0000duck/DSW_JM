using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DSMS.DSW.DAL
{
    /// <summary>
    /// 采集数据库类
    /// </summary>
    public class AutoCreateDB
    {

        //数据库是否存在
        public static bool CreateTable(string TableName)
        {

            try
            {
                StringBuilder strSql = new StringBuilder();

                strSql = new StringBuilder();
                strSql.AppendLine(" if not exists (select 1  from   dbo.sysobjects where    id = object_id('dbo.[" + TableName + "]') and   type = 'U'  ) ");
                strSql.AppendLine(" begin ");
                strSql.AppendLine(" CREATE TABLE [dbo].[" + TableName + "]( ");
                strSql.AppendLine("[Id] [int] IDENTITY(1,1) NOT NULL,");
                strSql.AppendLine("[DSType] [int] NOT NULL,");
                strSql.AppendLine(" [BarCode] [nvarchar](50) NULL,");
                strSql.AppendLine(" [Action] [nvarchar](50) NULL,");
                strSql.AppendLine(" [MatId] [uniqueidentifier] NULL,");
                strSql.AppendLine(" [MatCode] [nvarchar](50) NULL,");
                strSql.AppendLine(" [MatName] [nvarchar](50) NULL,");
                strSql.AppendLine(" [UnitType] [char](10) NULL,");
                strSql.AppendLine(" [UnitPrice] [decimal](18, 3) NULL,");
                strSql.AppendLine(" [DSQuantity] [decimal](18, 2) NULL,");
                strSql.AppendLine(" [RealQuantity] [decimal](18, 2) NULL,");
                strSql.AppendLine("	[TotalPrice] [decimal](18,5) NULL,");
                strSql.AppendLine("	[DeviceId] [uniqueidentifier] NULL,");
                strSql.AppendLine("	[DeviceName][nvarchar](50) NULL,");
                strSql.AppendLine("	[PotCode] [nvarchar](50) NULL,");
                strSql.AppendLine("	[PotName][nvarchar](50) NULL,");
                strSql.AppendLine(" [EntryDate] [datetime] NULL,");
                strSql.AppendLine("[EntryFilterYMD] [nvarchar](50) NULL,");
                strSql.AppendLine(" CONSTRAINT [PK_" + TableName + "] PRIMARY KEY CLUSTERED( ");
                strSql.AppendLine(" [Id] ASC )WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY] ");
                strSql.AppendLine(") ON [PRIMARY]");
                strSql.AppendLine(" end ");
                SQLHelper.RunProc(strSql.ToString());
                return true;
            }
            catch
            {
                return false;
            }

        }


        /// <summary>
        /// 判断是否存在表
        /// </summary>
        public static bool IsExistTable(string tableName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.AppendLine("select * from dbo.sysobjects where id = object_id('dbo.[" + tableName + "]')");
            try
            {
                DataTable dt = SQLHelper.RunProcToDataTable(strSql.ToString());
                if (dt.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }


        private bool _sqlConnected;

        public bool SQLConnected
        {
            set { _sqlConnected = value; }
            get
            {
                return IsSQLConnected();
            }

        }
        /// <summary>
        /// 判断是否存在表
        /// </summary>
        private bool IsSQLConnected()
        {


            try
            {
                SQLHelper.RunProc(" Select GetDate() ");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}