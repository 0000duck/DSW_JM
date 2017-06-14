using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace DSMS.DSW.Control.BLL
{
   public class WcfService
    {

        ServiceHost host = null;//定义 ServiceHost 
        //启动服务
        public void Excute()
        {

            
            host = new ServiceHost(typeof(DSMS.DSW.Control.BLL.Service));//WcfDemo.Service1 为引用的dll中的服务 

            host.Open();//启动服务 

        }

        //关闭服务
        public void Close()
        {
            if (host.State != CommunicationState.Closed)//判断服务是否关闭 
            {
                host.Close();//关闭服务 
            }

        }
    }
}
