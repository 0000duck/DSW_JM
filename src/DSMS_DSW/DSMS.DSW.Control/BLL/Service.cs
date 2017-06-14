using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSMS.DSW.Model;
using LitJson;

namespace DSMS.DSW.Control.BLL
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class Service : IService
    {

        static  List<CurrentDistributionModel> list = new List<CurrentDistributionModel>();
        public string DoWork()
        {
            try
            {
                if (Golbal.CurrentFormulaModel != null)
                {
                    CurrentDistributionModel model = new CurrentDistributionModel();
                    model.DeviceId = Golbal.CurrentFormulaModel.DeviceId.ToString();
                    model.DeviceName = Golbal.CurrentFormulaModel.DeviceName;
                    model.StandardQuantity = Golbal.CurrentFormulaModel.StandardQuantity;
                    model.FormulaName = Golbal.CurrentFormulaModel.FormulaName;
                    model.Customer = Golbal.CurrentFormulaModel.Customer;
                    model.Color = Golbal.CurrentFormulaModel.Color;
                    model.ProductName = Golbal.CurrentFormulaModel.ProductName;
                    model.ProductSpecification = Golbal.CurrentFormulaModel.ProductSpecification;
                    model.ProductWidth = Golbal.CurrentFormulaModel.ProductWidth;
                    model.ComNumber = Golbal.CurrentFormulaModel.CompleteCylinderNum;
                    model.RequestNumber = Golbal.CurrentFormulaModel.CylinderNum;
                    CurrentDistributionModel ss = list.SingleOrDefault(s => s.DeviceId == model.DeviceId);
                    if (ss != null)
                    {
                        list[list.IndexOf(ss)] = model;
                    }
                    else {
                        list.Add(model);
                    }
                }
                return JsonMapper.ToJson(list);
            }
            catch {
                return "err";
            }
          
        }
    }
}


