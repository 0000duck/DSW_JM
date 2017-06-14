using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Data;
using DSMS.DSW.Model;

namespace DSMS.DSW.DAL
{
   public class BarCodeDAL
    {
        public string GetBarCode(string Name, string day)
        {
            return GetBarCode(Name, day, 3);
        }
        private string GetBarCode(string name, string day, int Len)
        {
            try
            {
                var db = Database.Open();
                BarCodeModel model = db.UA_BarCodes.Find(db.UA_BarCodes.Name == name && db.UA_BarCodes.day == day);

                if (model == null)
                {
                    model = new BarCodeModel();
                    model.Id = Guid.NewGuid();
                    model.Name = name;
                    model.day = day;
                    model.max = 1;
                    db.UA_BarCodes.Insert(model);
                }
                else {
                      model.max += 1;
                      db.UA_BarCodes.Update(model);
                    }
                return model.Name + model.day + model.max.ToString().PadLeft(Len,'0');
            }
            catch
            {
                return null;
            }
        }
    }
}
