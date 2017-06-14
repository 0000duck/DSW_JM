using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSMS.DSW.Control.BLL
{
   public class QueuesListen
    {

        #region 参数定义
        //DataTable dt = new DataTable();
        //DSW_AlarmTableDAL AlarmTableDAL = new DSW_AlarmTableDAL();
        //DSW_CurrentRequestDAL CurrentRequestDAL = new DSW_CurrentRequestDAL();
        //DSW_RequestQueuesDAL RequestQueuesDAL = new DSW_RequestQueuesDAL();
        //ProcExecDAL procExecDAL = new ProcExecDAL();
        //DSW_ConfirmFormulaDAL ConfirmFormulaDAL = new DSW_ConfirmFormulaDAL();

        public static Dictionary<string, int> PotDictionary = new Dictionary<string, int>(); //Key= PotCode,Value =Status( 1报警  2插入队列 3执行完成，并移除  )  

        #endregion

        public void Excute()
        {
            //DeviceInfoDAL deviceInfoDAL = new DeviceInfoDAL();
            //dt = deviceInfoDAL.GetList(" Type=3");

            //System.Threading.Thread threadAlarm = new System.Threading.Thread(new ThreadStart(ListenAlarm));
            //threadAlarm.Start();
            //System.Threading.Thread threadQueues = new System.Threading.Thread(new ThreadStart(ListenthreadQueues));
            //threadQueues.Start();
        }
    }
}
