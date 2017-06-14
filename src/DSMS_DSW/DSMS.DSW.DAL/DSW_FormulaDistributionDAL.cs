using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.Model;
using Simple.Data;

namespace DSMS.DSW.DAL
{
   public class DSW_FormulaDistributionDAL
    {
       public bool Add( DSW_FormulaDistributionModel model)
       {

           try
           {
               var db = Database.Open();

               db.DSW_FormulaDistributions.Insert(model);
               return true;
           }
           catch {
               return false;
           
           }
       
       }

    }
}
