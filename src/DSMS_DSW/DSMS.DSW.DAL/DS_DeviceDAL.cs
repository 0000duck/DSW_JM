using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DSMS.DSW.Model;
using Simple.Data;

namespace DSMS.DSW.DAL
{
    public class DS_DeviceDAL
    {

        public List<DS_DeviceModel> GetList(int type)
        {

            try
            {
                var db = Database.Open();
                return db.DS_Devices.All().Where(db.DS_Devices.Type == type).OrderBy(db.DS_Devices.Code);
            }
            catch
            {

                return null;
            }
        }


        public DS_DeviceModel GetDeviceByCode(string code)
        {

            try
            {
                var db = Database.Open();
                return db.DS_Devices.Find(db.DS_Devices.Code == code);
            }
            catch
            {

                return null;
            }
        }
  

        public DS_DeviceModel GetDeviceByIP(string ip)
        {

            try
            {
                var db = Database.Open();
                return db.DS_Devices.Find(db.DS_Devices.IP == ip);
            }
            catch
            {

                return null;
            }
        }


        public View_DeviceInfoModel GetDeviceInfoByPotCode(string potcode)
        {

            try
            {
                var db = Database.Open();
                return db.View_DeviceInfos.Find(db.View_DeviceInfos.PotCode==potcode);
            }
            catch
            {

                return null;
            }
        }


        public List<View_DeviceInfoModel> GetPotCodeList(int type)
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
