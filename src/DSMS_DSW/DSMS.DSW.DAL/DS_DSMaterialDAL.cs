using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using DSMS.DSW.Model;
using System.Data.SqlClient;
using Simple.Data;

namespace DSMS.DSW.DAL
{
   public class DS_DSMaterialDAL 
   {

       public DS_DSMaterialModel GetMaterialByCode(string matCode)
       {
           try {
               var db = Database.Open();
               return db.DS_DSMaterials.Find(db.DS_DSMaterials.Code == matCode);
           
           }

           catch {

               return null;
           
           }
       }


       public List<DS_DSMaterialModel> GetMaterialList()
       {
           try
           {
               var db = Database.Open();
               return db.DS_DSMaterials.All().Where(db.DS_DSMaterials.Distribution2==true).OrderBy(db.DS_DSMaterials.Code);
           }

           catch
           {

               return null;

           }
       }


       public List<DS_DSMaterialModel> GetMaterialListAll()
       {
           try
           {
               var db = Database.Open();
               return db.DS_DSMaterials.All().OrderBy(db.DS_DSMaterials.Code);
           }

           catch
           {

               return null;

           }
       }


       public List<DS_DSMaterialModel> GetMaterialByDistributionType(int distributiontype)
       {
           try
           {
               var db = Database.Open();
               if (distributiontype==1)
                   return db.DS_DSMaterials.All().Where(db.DS_DSMaterials.Distribution1 == true).OrderBy(db.DS_DSMaterials.Code);
               else if(distributiontype==2)
                   return db.DS_DSMaterials.All().Where(db.DS_DSMaterials.Distribution2 == true).OrderBy(db.DS_DSMaterials.Code);
               else
                   return db.DS_DSMaterials.All().Where(db.DS_DSMaterials.Distribution3 == true).OrderBy(db.DS_DSMaterials.Code);
           }
           catch
           {

               return null;

           }
       }

    }
}
