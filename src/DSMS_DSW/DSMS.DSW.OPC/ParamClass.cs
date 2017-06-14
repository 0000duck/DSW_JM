using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DSMS.DSW.OPC
{
   public class ParamClass
    {

  
        private static volatile ParamClass instance;
        private static object lockHelper = new object(); //加锁防止多线程情况
        public  List<Param> ParamList = new List<Param>();
        public static ParamClass Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new ParamClass();
                        }
                    }
                }
                return instance;
            }

        }

        OpcReadAndWrite opcReadAndWrite;



        private ParamClass()
        {
            ParamList.Add(new Param { Code = "01", LabelName = "助剂配送机台缸号", KepAddress = "PLC.PLC.QW376" });
            ParamList.Add(new Param { Code = "02", LabelName = "助剂配送助剂编号", KepAddress = "PLC.PLC.QW378" });
            ParamList.Add(new Param { Code = "03", LabelName = "助剂配送目标量", KepAddress = "PLC.PLC.QD384" });
            ParamList.Add(new Param { Code = "04", LabelName = "助剂配送状态", KepAddress = "PLC.PLC.QW374" });
            ParamList.Add(new Param { Code = "05", LabelName = "助剂配送实际", KepAddress = "PLC.PLC.QD452" });

            ParamList.Add(new Param { Code = "06", LabelName = "机台放水缸号", KepAddress = "PLC.PLC.QW362" });
            ParamList.Add(new Param { Code = "07", LabelName = "机台放水目标量", KepAddress = "PLC.PLC.QD368" });
            ParamList.Add(new Param { Code = "08", LabelName = "机台放水状态", KepAddress = "PLC.PLC.QW358" });
            ParamList.Add(new Param { Code = "09", LabelName = "机台放水实际", KepAddress = "PLC.PLC.QD476" });
            ParamList.Add(new Param { Code = "10", LabelName = "配送总量实际", KepAddress = "PLC.PLC.QD456" });
            ParamList.Add(new Param { Code = "11", LabelName = "配方状态", KepAddress = "PLC.PLC.QW2000" });



            ParamList.Add(new Param { Code = "12", LabelName = "水洗助剂配送机台缸号", KepAddress = "PLC.PLC.QW332" });
            ParamList.Add(new Param { Code = "13", LabelName = "水洗助剂配送目标量", KepAddress = "PLC.PLC.QD336" });
            ParamList.Add(new Param { Code = "14", LabelName = "水洗助剂配送状态", KepAddress = "PLC.PLC.QW320" });
            ParamList.Add(new Param { Code = "15", LabelName = "水洗助剂配送实际", KepAddress = "PLC.PLC.QD468" });
            ParamList.Add(new Param { Code = "16", LabelName = "水洗机台放水缸号", KepAddress = "PLC.PLC.QW350" });
            ParamList.Add(new Param { Code = "17", LabelName = "水洗机台放水目标量", KepAddress = "PLC.PLC.QD352" });
            ParamList.Add(new Param { Code = "18", LabelName = "水洗机台放水状态", KepAddress = "PLC.PLC.QW346" });
            ParamList.Add(new Param { Code = "19", LabelName = "水洗机台放水实际", KepAddress = "PLC.PLC.QD472" });
            ParamList.Add(new Param { Code = "199", LabelName = "水洗机台配送总量", KepAddress = "PLC.PLC.QD1000" });
            ParamList.Add(new Param { Code = "20", LabelName = "水洗配方状态", KepAddress = "PLC.PLC.QW1998" });

            ParamList.Add(new Param { Code = "21", LabelName = "A_311", KepAddress = "PLC.PLC.QW208" });
            ParamList.Add(new Param { Code = "22", LabelName = "A_312", KepAddress = "PLC.PLC.QW210" });
            ParamList.Add(new Param { Code = "23", LabelName = "A_321", KepAddress = "PLC.PLC.QW214" });
            ParamList.Add(new Param { Code = "24", LabelName = "A_322", KepAddress = "PLC.PLC.QW216" });
            ParamList.Add(new Param { Code = "25", LabelName = "A_331", KepAddress = "PLC.PLC.QW118" });
            ParamList.Add(new Param { Code = "26", LabelName = "A_332", KepAddress = "PLC.PLC.QW120" });
            ParamList.Add(new Param { Code = "27", LabelName = "A_341", KepAddress = "PLC.PLC.QW102" });
            ParamList.Add(new Param { Code = "28", LabelName = "A_342", KepAddress = "PLC.PLC.QW104" });
            opcReadAndWrite = new OpcReadAndWrite(this);
        }

        public enum ParamEnum
        {
            助剂配送机台缸号,
            助剂配送助剂编号,
            助剂配送目标量,
            助剂配送状态,
            机台放水缸号,
            机台放水目标量,
            机台放水状态,
            配方状态,
           
            水洗助剂配送机台缸号,
            水洗助剂配送助剂编号, 
            水洗助剂配送目标量,
            水洗助剂配送状态,
            水洗机台放水缸号,
            水洗机台放水目标量,
            水洗机台放水状态,
            水洗配方状态
        }


        public bool IsAlarming(string potCode)
        { 
           bool isAlarm =false;

           switch (potCode)
           {
               //case "211": isAlarm = A_211 == "1" ? true : false; break;
               //case "212": isAlarm = A_212 == "1" ? true : false; break;
               //case "221": isAlarm = A_221 == "1" ? true : false; break;
               //case "222": isAlarm = A_222 == "1" ? true : false; break;
               //case "231": isAlarm = A_231 == "1" ? true : false; break;
               //case "232": isAlarm = A_232 == "1" ? true : false; break;
               //case "241": isAlarm = A_241 == "1" ? true : false; break;
               //case "242": isAlarm = A_242 == "1" ? true : false; break;
               //case "251": isAlarm = A_251 == "1" ? true : false; break;
               //case "252": isAlarm = A_252 == "1" ? true : false; break;
               //case "261": isAlarm = A_261 == "1" ? true : false; break;
               //case "262": isAlarm = A_262 == "1" ? true : false; break;

               case "311": isAlarm = A_311 == "1" ? true : false; break;
               case "312": isAlarm = A_312 == "1" ? true : false; break;
               case "321": isAlarm = A_321 == "1" ? true : false; break;
               case "322": isAlarm = A_322 == "1" ? true : false; break;
               case "331": isAlarm = A_331 == "1" ? true : false; break;
               case "332": isAlarm = A_332 == "1" ? true : false; break;
               case "341": isAlarm = A_341 == "1" ? true : false; break;
               case "342": isAlarm = A_342 == "1" ? true : false; break;
              
               default: break;
           }

           return isAlarm;
        }



        /// <summary>
        /// 机缸报警
        /// </summary>
        //public string A_211 { get; set; }
        //public string A_212 { get; set; }
        //public string A_221 { get; set; }
        //public string A_222 { get; set; }
        //public string A_231 { get; set; }
        //public string A_232 { get; set; }
        //public string A_241 { get; set; }
        //public string A_242 { get; set; }
        //public string A_251 { get; set; }
        //public string A_252 { get; set; }
        //public string A_261 { get; set; }
        //public string A_262 { get; set; }

        public string A_311 { get; set; }
        public string A_312 { get; set; }
        public string A_321 { get; set; }
        public string A_322 { get; set; }
        public string A_331 { get; set; }
        public string A_332 { get; set; }
        public string A_341 { get; set; }
        public string A_342 { get; set; }



        ////---------------定型机--------------------
      
        /// <summary>
        /// 助剂配送
        /// </summary>
        public string 助剂配送机台缸号 { get; set; }
        public string 助剂配送助剂编号 { get; set; }
        public string 助剂配送目标量 { get; set; }
        public string 助剂配送状态 { get; set; }


        string _matreal;
        public string 助剂配送实际
        {
            set { _matreal = value; }
            get
            {
                decimal oDecimal = 0;
                if (decimal.TryParse(_matreal, out oDecimal))
                    return oDecimal.ToString("0.00");
                else { return "0.00"; }
            }
        }




       /// <summary>
       /// 机台放水
       /// </summary>
       public string 机台放水缸号 { get; set; }
       public string 机台放水目标量 { get; set; }
       public string 机台放水状态 { get; set; }
         
         
      string _waterreal;
      public string 机台放水实际
      {
             set{ _waterreal=value; }
             get
             {  
                  decimal oDecimal = 0;
                 if (decimal.TryParse(_waterreal, out oDecimal))
                     return oDecimal.ToString("0.00");
                 else { return "0.00"; }
             }
         }


      string _watertotal;
      public string 水洗机台配送总量
      {
          set { _watertotal = value; }
          get
          {
              decimal oDecimal = 0;
              if (decimal.TryParse(_watertotal, out oDecimal))
                  return oDecimal.ToString("0.00");
              else { return "0.00"; }
          }
      }
       

        string _total;
        public string 配送总量实际
        {
            set { _total = value; }
            get
            {
                decimal oDecimal = 0;
                if (decimal.TryParse(_total, out oDecimal))
                    return oDecimal.ToString("0.00");
                else { return "0.00"; }
            }
        }


        public string 配方状态 { get; set; }

 
        ////---------------End--------------------




        ////---------------水洗机--------------------

        public string 水洗助剂配送机台缸号 { get; set; }
        public string 水洗助剂配送助剂编号 { get; set; }
        public string 水洗助剂配送目标量 { get; set; }
        public string 水洗助剂配送状态 { get; set; }

        string _washingmaterialreal;
        public string 水洗助剂配送实际 {

            set { _washingmaterialreal = value; }
            get
            {
                decimal oDecimal = 0;
                if (decimal.TryParse(_washingmaterialreal, out oDecimal))
                    return oDecimal.ToString("0.00");
                else { return "0.00"; }
            }
        }


        public string 水洗机台放水缸号 { get; set; }
        public string 水洗机台放水目标量 { get; set; }
        public string 水洗机台放水状态 { get; set; }

        string _washingwaterreal;
        public string 水洗机台放水实际
        {
            set { _washingwaterreal = value; }
            get
            {
                decimal oDecimal = 0;
                if (decimal.TryParse(_washingwaterreal, out oDecimal))
                    return oDecimal.ToString("0.00");
                else { return "0.00"; }
            }
        }

        public string 水洗配方状态 { get; set; }
        ////---------------End--------------------
   
       /// <summary>
       /// PLC写入
       /// </summary>
        public void OpcSyncWrite(ParamEnum p, string Value)
       {
           opcReadAndWrite.SyncWrite(p.ToString(), Value);
       }
        /// <summary>
        /// PLC写入
        /// </summary>
        public void OpcSyncWrite(string  strtag, string Value)
        {
            opcReadAndWrite.SyncWrite(strtag, Value);
        }


        /// <summary>
        /// PLC读取
        /// </summary>
        public string OpcSyncRead(ParamEnum p )
        {
            Type type = this.GetType(); //获取类型
            System.Reflection.PropertyInfo propertyInfo = type.GetProperty(p.ToString()); //获取指定名称的属性
            return propertyInfo.GetValue(this, null).ToString(); //获取属性值
       
        }


       /// <summary>
       /// 释放链接
       /// </summary>
       public void Dispose()
       {
           opcReadAndWrite.ConnDispose();
       }



       #region  配送方法


       /// <summary>
       /// 助剂配送
       /// </summary>
       public void FucMaterialDS(string potCode, string matCode, decimal quantity)
       {

           OpcSyncWrite(ParamEnum.助剂配送机台缸号, potCode);
           OpcSyncWrite(ParamEnum.助剂配送助剂编号, matCode);
           OpcSyncWrite(ParamEnum.助剂配送目标量, quantity.ToString());
           Thread.Sleep(500);
           if (助剂配送机台缸号 == potCode && 助剂配送助剂编号 == matCode && 助剂配送目标量 == ZeroRemove(quantity))
           {
               OpcSyncWrite(ParamEnum.助剂配送状态, "1");
           }
           else
           {
               FucMaterialDS(potCode, matCode, quantity);
           }
       }
       /// <summary>
       /// 机台放水
       /// </summary>
       public void FucWaterDS(string potCode, decimal quantity)
       {
           OpcSyncWrite(ParamEnum.机台放水缸号, potCode);
           OpcSyncWrite(ParamEnum.机台放水目标量, quantity.ToString());


           Thread.Sleep(500);

           if (机台放水缸号 == potCode && 机台放水目标量 == ZeroRemove(quantity))
           {
               OpcSyncWrite(ParamEnum.机台放水状态, "1");
           }
           else
           {
               FucWaterDS(potCode, quantity);
           }
       }
       /// <summary>
       /// 末端排放
       /// </summary>
       public void FucEndWater(string potCode, string matCode, decimal quantity)
       {
           string endCode = string.Empty;
           ///待修改!!!!!
           switch (potCode)
           {
               case "211": endCode = "200"; break;
               case "212": endCode = "200"; break;
               case "221": endCode = "200"; break;
               case "222": endCode = "200"; break;
               case "231": endCode = "200"; break;
               case "232": endCode = "200"; break;
               case "241": endCode = "200"; break;
               case "242": endCode = "200"; break;
               case "251": endCode = "200"; break;
               case "252": endCode = "200"; break;
               case "261": endCode = "200"; break;
               case "262": endCode = "200"; break;
           }

           OpcSyncWrite(ParamEnum.助剂配送机台缸号, endCode);
           OpcSyncWrite(ParamEnum.助剂配送助剂编号, matCode);
           OpcSyncWrite(ParamEnum.助剂配送目标量, quantity.ToString());

           Thread.Sleep(500);
           if (助剂配送机台缸号 == endCode && 助剂配送助剂编号 == matCode && 助剂配送目标量 == ZeroRemove(quantity))
           {
               OpcSyncWrite(ParamEnum.助剂配送状态, "1");
           }
           else
           {
               FucEndWater(potCode, matCode, quantity);
           }
       }



       /// <summary>
       /// 水洗助剂配送
       /// </summary>
       public void FucWashingMaterialDS(string potCode, decimal quantity)
       {
           OpcSyncWrite(ParamEnum.水洗助剂配送机台缸号, potCode);
           OpcSyncWrite(ParamEnum.水洗助剂配送目标量, quantity.ToString());
           Thread.Sleep(500);
           if (水洗助剂配送机台缸号 == potCode &&水洗助剂配送目标量 == ZeroRemove(quantity))
           {
               OpcSyncWrite(ParamEnum.水洗助剂配送状态, "1");
           }
           else
           {
               FucWashingMaterialDS(potCode, quantity);
           }
       }


       /// <summary>
       /// 水洗机台放水
       /// </summary>
       public void FucWashingWaterDS(string potCode, decimal quantity)
       {
           OpcSyncWrite(ParamEnum.水洗机台放水缸号, potCode);
           OpcSyncWrite(ParamEnum.水洗机台放水目标量, quantity.ToString());

           Thread.Sleep(500);

           if (水洗机台放水缸号 == potCode && 水洗机台放水目标量 == ZeroRemove(quantity))
           {
               OpcSyncWrite(ParamEnum.水洗机台放水状态, "1");
           }
           else
           {
               FucWashingWaterDS(potCode, quantity);
           }
       }
       #endregion

       #region 其他方法
       private string ZeroRemove(decimal quantity)
       {
           //移除小数末尾的零
           string str = string.Empty;
           str = quantity.ToString();
           if (str.Contains("."))
           {
               str = str.TrimEnd('0');//移除末尾零
               str = str.TrimEnd('.');//移除末尾的'.'
           }
           return str;
       }
       #endregion
    }
     
}
public class Param
{
    public string Code { get; set; }
    public string LabelName { get; set; }
    public string KepAddress { get; set; }
}