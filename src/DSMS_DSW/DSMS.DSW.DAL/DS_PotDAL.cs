using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSMS.DSW.Model;
using Simple.Data;

namespace DSMS.DSW.DAL
{
   public class DS_PotDAL
    {
        /// <summary>
        /// 更据条码查询
        /// </summary>
       public List<DS_PotModel> GetPotList()
        {
            try
            {
                var db = Database.Open();
                return db.DS_Pots.All().OrderBy(db.DS_Pots.PotCode);
            }

            catch {

                return null;
            }
        }


       /// <summary>
       /// 更据条码查询
       /// </summary>
       public List<View_DeviceInfoModel> GetPotListByType( int  type)
       {
           try
           {
               var db = Database.Open();
               return db.View_DeviceInfos.All().Where(db.View_DeviceInfos.Type == type).OrderBy(db.View_DeviceInfos.PotCode);
           }
           catch
           {

               return null;
           }
       }


    }
}
