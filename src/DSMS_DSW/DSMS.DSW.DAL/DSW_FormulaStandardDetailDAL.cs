using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.Models;
using Simple.Data;

namespace DSMS.DSW.DAL
{
  public  class DSW_FormulaStandardDetailDAL
    {


      public bool UpdateFormulaStandard(Guid parentId, List<DSW_FormulaStandardDetailModel> list)
      {
          try
          {
               var db = Database.Open();
               db.DSW_FormulaStandardDetails.Delete(ParentId:parentId);
               foreach (DSW_FormulaStandardDetailModel model in list)
               {
                   db.DSW_FormulaStandardDetails.Insert(model);
               }
              return true;

          }
          catch {
              return false;
          }
      }
    }
}
