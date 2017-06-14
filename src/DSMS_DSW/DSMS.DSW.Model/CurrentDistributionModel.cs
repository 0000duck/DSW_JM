using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Model
{
   public partial class CurrentDistributionModel
    {

       //机台Id
       public string DeviceId { get; set; }

       //机台名称
       public string DeviceName { get; set; }

       //标量
       public decimal  StandardQuantity { get; set; }

       //配方名称
       public string FormulaName { get; set; }

       //客户名称
       public string Customer { get; set; }

       //花色
       public string Color { get; set; }

       //产品名称
       public string ProductName { get; set; }

       //产品规格
       public string ProductSpecification { get; set; }

       //产品门幅
       public string ProductWidth { get; set; }

       //机台缸数
       public int ComNumber { get; set; }

       //完成缸数
       public int RequestNumber { get; set; }


    }
}
