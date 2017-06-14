using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using DSMS.DSW.Model;
using DSMS.DSW.Control.Action;
using DSMS.DSW.OPC;
using DSMS.DSW.DAL;

namespace DSMS.DSW.Control
{
    public class Golbal
    {

        public  Golbal()
        {
        _intervalwater = Convert.ToDecimal(System.Configuration.ConfigurationManager.AppSettings["IntervalWater"].ToString());//间隔水量
        _cleanwater = decimal.Parse(System.Configuration.ConfigurationManager.AppSettings["CleanWater"].ToString());  //清洗水量
        _endwater = decimal.Parse(System.Configuration.ConfigurationManager.AppSettings["EndWater"].ToString());  //末端水量
        _serverIP = System.Configuration.ConfigurationManager.AppSettings["ServerIP"].ToString(); //服务器IP
        _localIP = System.Configuration.ConfigurationManager.AppSettings["LocalIP"].ToString(); //本地IP
        _perSum = decimal.Parse(System.Configuration.ConfigurationManager.AppSettings["PerSum"].ToString());  //末端水量
        ParamClass = ParamClass.Instance;
        CurrentAction = "等待机台请求";
        WashingCurrentAction= "等待机台请求";     
        DS_PotDAL potDAL = new DS_PotDAL();
        potList = potDAL.GetPotList();//获取所有缸信息
        DS_DSMaterialDAL DAL = new DS_DSMaterialDAL();
        WaterModel = DAL.GetMaterialByCode("99");
        }

        #region 公共参数
        private static decimal _intervalwater;
         private static decimal _cleanwater;
         private static decimal _endwater;
         private static string _serverIP;
         private static string _localIP;
         private static decimal _perSum;
        //间隔水
        public static decimal IntervalWater{
          get { return _intervalwater; }
          set{ _intervalwater=value; }
        
        }

        //清洗水
        public static decimal CleanWater
        {
            get { return _cleanwater; }
            set { _cleanwater = value; }

        }


        //末端排放
        public static decimal EndWater
        {
            get { return _endwater; }
            set { _endwater = value; }

        }


        //服务器IP
        public static string ServerIP
        {
            get { return _serverIP; }
            set { _serverIP = value; }

        }
        //本地IP
        public static string LocalIP
        {
            get { return _localIP; }
            set { _localIP = value; }
        
        }

        //配送均速
        public static decimal PerSum
        {
            get { return _perSum; }
            set { _perSum = value; }

        }

        
        public static  List<DS_PotModel> potList;

        public static DS_DSMaterialModel WaterModel { get; set; }

        public static string FilePath = Application.StartupPath + @"\Current";

        /// <summary>
        /// DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time"> DateTime时间格式</param>
        /// <returns>Unix时间戳格式</returns>
        public static int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }

        public static ParamClass ParamClass;
        #endregion

        #region  定型机

        public static string CurrentAction { get; set; }

        public static int DSStep = 0; //0未开始  1助剂配送  2间隔水 3清洗水 4 末端排放 5末端排放完成

        public static int WaterStep = 0; //0未开始  1开始配送  2配送结束

        public static View_FormulaInfoModel CurrentFormulaModel { get; set; } //当前配送配方

        public static string CurrentPotCode { get; set; } //当前配送缸号

        public static string CurrentPotName { get; set; } //当前配送缸号

        public static decimal CurrentCabinetWaterQuantity { get; set; } //当前机台放水量

        
        public static List<View_FormulaInfoModel> MyQueueList = new List<View_FormulaInfoModel>(); //机台配送队列

        public static Queue<DsMaterial> MaterialQueue = new Queue<DsMaterial>();  //助剂队列
        public static FormulaStatus formulaStatus = new FormulaStatus();


        //开始执行
        public static void Excute(View_FormulaInfoModel model, string potCode)
        {
            DSStep = 1;
            WaterStep = 1;

           
            CurrentFormulaModel = model;
            CurrentPotCode = potCode;
            Golbal.CurrentPotName = potList.FirstOrDefault(s => s.PotCode == Golbal.CurrentPotCode).PotName;
            MaterialQueue.Clear();
            decimal minus = 0;
            foreach (View_FormulaDetailInfoModel detailModel in model.list.OrderBy(s => s.Sort))
            {
                DsMaterial dsmaterial = new DsMaterial();
                dsmaterial.MaterialId = detailModel.MaterialId.ToString();
                dsmaterial.MaterialCode = detailModel.MaterialCode;
                dsmaterial.MaterialName = detailModel.MaterialName;
                dsmaterial.MaterialQuantity = detailModel.MaterialQuantity;
                dsmaterial.Unit = detailModel.Unit;
                dsmaterial.Price = detailModel.Price.Value;
                MaterialQueue.Enqueue(dsmaterial);
                minus += dsmaterial.MaterialQuantity + IntervalWater;
            }

            CurrentCabinetWaterQuantity = model.Quantity - minus - CleanWater;
            formulaStatus.FormulaStart(ParamClass);//开始写入配方状态 0;
      
        }

        //执行结束
        public static void EndExcute()
        {
            CurrentAction = "配送完成";
            formulaStatus.FormulaEnd(ParamClass);//开始写入配方状态 1;
        
        }


        #endregion


        #region 水洗机

        public static int WashingDSStep = 0; //0未开始  1助剂配送 2配送完成

        public static int WashingWaterStep = 0; //0未开始  1开始配送  2配送结束

        public static List<View_WashingModel> MyWashingList = new List<View_WashingModel>(); //机台配送队列 

        public static View_WashingModel CurrentWashingaModel { get; set; } //当前水洗配方


        public static WashingFormulaStatus washingformulaStatus = new WashingFormulaStatus();

        public static string WashingCurrentAction { get; set; }

        public static string WashingCurrentPotCode { get; set; } //当前配送缸号

        public static string WashingCurrentPotName { get; set; } //当前配送缸号


        //开始执行
        public static void WashingExcute(View_WashingModel model )
        {

            CurrentWashingaModel = model;
            WashingCurrentPotCode = model.PotCode;
            WashingCurrentPotName = potList.FirstOrDefault(s => s.PotCode == WashingCurrentPotCode).PotName;
            washingformulaStatus.FormulaStart(ParamClass);//开始写入配方状态 0;

        }

        //执行结束
        public static void WashingEndExcute()
        {
            WashingCurrentAction = "配送完成";
            washingformulaStatus.FormulaEnd(ParamClass);//开始写入配方状态 1;

        }

        #endregion 



        #region  公共方法


        static DS_RecordDAL recordDAL = new DS_RecordDAL();
        static DS_DeviceDAL deviceDAL = new DS_DeviceDAL();
        public static void RecordAdd(int dsType,string barCode, string potCode, DsRecord dsRecord, DsMaterial dsMaterial)
        {
            View_DeviceInfoModel viewModel = deviceDAL.GetDeviceInfoByPotCode(potCode);


            DS_RecordModel recordModel = new DS_RecordModel();
            recordModel.DSType = dsType;
            recordModel.Action = dsRecord.ActionName;
            recordModel.BarCode = barCode;
            recordModel.MatId = new Guid(dsMaterial.MaterialId);
            recordModel.MatCode = dsMaterial.MaterialCode;
            recordModel.MatName = dsMaterial.MaterialName;
            recordModel.DSQuantity = dsMaterial.MaterialQuantity;
            recordModel.RealQuantity = dsRecord.DSQuantity;
            recordModel.UnitType = dsMaterial.Unit;
            recordModel.UnitPrice = dsMaterial.Price;
            recordModel.TotalPrice = recordModel.RealQuantity * recordModel.UnitPrice;

            recordModel.DeviceId = viewModel.DeviceId;
            recordModel.DeviceName = viewModel.DeviceName;
            recordModel.PotCode = viewModel.PotCode;
            recordModel.PotName = viewModel.PotName;
            recordModel.EntryDate = DateTime.Now;
            recordModel.EntryFilterYMD = DateTime.Now.ToString("yyyyMMdd");
            recordDAL.Add(recordModel);
        }
        #endregion


    }
}

public class DsRecord
{
    public string ActionName { get; set; }
    public string MaterialName { get; set; }
    public decimal DSQuantity { get; set; }
    public string EntryDate { get; set; } // HH:mm:ss
}

public class DsMaterial
{
    public string MaterialId { get; set; }
    public string MaterialCode{ get; set; }
    public string MaterialName { get; set; }
    public decimal MaterialQuantity { get; set; }
    public string Unit { get; set; }
	public decimal Price { get; set; }
} 

 