using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.Model;
using Simple.Data;

namespace DSMS.DSW.DAL
{
   public class DSW_FormulaDAL
    {


        /// <summary>
        /// 更据条码查询
        /// </summary>
       public DSW_FormulaModel GetModelById(Guid id)
        {
            try
            {
                var db = Database.Open();
                return db.DSW_Formulas.Get(id);
            }
            catch
            {
                return null;
            }

        }


    }
}
