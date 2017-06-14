using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.Model;
using Simple.Data;

namespace DSMS.DSW.DAL
{
   public class DSW_ParamTableDAL
    {

        //public DataTable GetList(string strWhere)
        //{

        //    StringBuilder strSql = new StringBuilder();
        //    strSql.AppendLine("Select * from DSW_ParamTable ");

        //    if (!string.IsNullOrEmpty(strWhere))
        //    {
        //        strSql.AppendLine(" Where " + strWhere);
        //    }

        //    return SQLHelper.RunProcToDataTable(strSql.ToString());
        //}

       public List<DSW_ParamTableModel> GetList(string like)
       {
           try
           {
               var db = Database.Open();
               var expr1 = db.DSW_ParamTables.RW.Like("%" + like + "%");
               return db.DSW_ParamTables.All().Where(expr1).OrderBy(db.DSW_ParamTables.KepAddress);
           }
           catch
           {
               return null;
           }
       
       
       
       }
    }
}
