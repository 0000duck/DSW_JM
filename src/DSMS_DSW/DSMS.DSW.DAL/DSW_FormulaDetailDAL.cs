using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.Model;
using Simple.Data;

namespace DSMS.DSW.DAL
{
   public class DSW_FormulaDetailDAL
    {





        /// <summary>
        /// 根据条码查询
        /// </summary>
        public View_FormulaInfoModel GetModelById(Guid id)
        {
            try
            {
                var db = Database.Open();
                return db.View_FormulaInfos.Find(db.View_FormulaInfos.Id == id);
            }
            catch
            {
                return null;
            }

        }

   
       /// <summary>
       /// 根据条码查询
       /// </summary>
       public View_FormulaInfoModel GetModelByBarCode(string barCode)
       {
           try
           {
               var db = Database.Open();
               return db.View_FormulaInfos.Find(db.View_FormulaInfos.BarCode == barCode);
           }
           catch {
               return null;
           }

       }


       public List<View_FormulaDetailInfoModel> GetFormulaDetailInfoList(string barCode)
       {
           try
           {
               var db = Database.Open();
               return db.View_FormulaDetailInfos.FindAllBy(BarCode: barCode).OrderBy(db.View_FormulaDetailInfos.Sort);
           }
           catch {
               return null;
           }
       }

       //更新状态
       public bool UpdateDSW_FormulaDetailStatus(Guid Id ,int status)
       {
           try
           {
                var db = Database.Open();
                db.DSW_FormulaDetails.UpdateById(Id: Id, Status: status);
                return true;
           }
           catch
           {
               return false;
           }
       }




       //更新条码
       public bool UpdateDSW_FormulaDetailNewBarCode(Guid formulaStandardId)
       {
           BarCodeDAL barCodeDAL = new BarCodeDAL();
           try
           {
               var db = Database.Open();
               List<DSW_FormulaDetailModel> list = db.DSW_FormulaDetails.All().Where(db.DSW_FormulaDetails.FormulaStandardId == formulaStandardId);
               foreach (DSW_FormulaDetailModel model in list)
               {
               model.BarCode = barCodeDAL.GetBarCode("111", DateTime.Now.ToString("yyMMdd"));
               db.DSW_FormulaDetails.Update(model);
               }
               return true;
           }
           catch
           {
               return false;
           }
       }
    }
}
