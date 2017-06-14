using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.Model;
using Simple.Data;
using System.Data;

namespace DSMS.DSW.DAL
{
   public class DSW_FormulaStandardDAL
    {

       public List<DSW_FormulaStandardModel> GetList()
       {

           try {
               var db = Database.Open();
               return db.DSW_FormulaStandards.All().Where(db.DSW_FormulaStandards.Type == 1).OrderBy(db.DSW_FormulaStandards.Name); 
           
           }
           catch {
               return null;
           }
       }

       public List<View_FormulaStandardDetailModel> GetListByParnetId(Guid parnetId)
       {

           try
           {
               var db = Database.Open();
               return db.View_FormulaStandardDetails.All().Where(db.View_FormulaStandardDetails.ParentId == parnetId).OrderBy(db.View_FormulaStandardDetails.Sort);

           }
           catch
           {
               return null;
           }
       }

       public DataTable GetView_DSW_FormulaStandard()
       {

           try
           {
               StringBuilder strSql = new StringBuilder();
               strSql.Append("Select Id,Name,data,EntryDate From View_DSW_FormulaStandard  ");
               strSql.Append("Where Type =0 ");
               strSql.Append("Order by EntryDate DESC ");
               return SQLHelper.RunProcToDataTable(strSql.ToString());
           }
           catch {
               return null;
           }
       }

    }
}
