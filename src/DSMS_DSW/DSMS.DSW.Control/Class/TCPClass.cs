using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;

namespace DSMS.DSW.Control.Class
{
   public class TCPClass
   {

       #region 公共变量
       TcpClient client = null;//TcpClient实例  
       NetworkStream stream = null;//网络流
       int localPort = 20000;  //自定义
       int remotePort = 11000; //自定义
       public EventHandler Receive_Event;
       public EventHandler Error_Event;

        Queue<CSend> SendQueue = new Queue<CSend>();
       #endregion
       public TCPClass()
       {
           ListenClient();

           Task.Factory.StartNew(() =>  //线程执行任务
          {
              while (true)
              {

                  if (SendQueue.Count > 0)
                  {
                      CSend csend = SendQueue.Dequeue();
                      if (csend!=null&&ByPing(csend.RemoteIP))
                      {
                          SendToClient(csend.RemoteIP, csend.SendString);
                      }
                      
                  }
                  Thread.Sleep(100);
              }
          });
       }

       public void SendString(IPAddress ip ,string s)
       {
           SendQueue.Enqueue(new CSend(ip, s));
       }

       //获取本地IP地址
       private IPAddress GetIPAddress()
       {
           IPAddress ipaddr = null;
           //获取本机IP
           IPHostEntry ipe = Dns.GetHostEntry(Dns.GetHostName());
           foreach (IPAddress ip in ipe.AddressList)
           {

               if (System.Net.Sockets.AddressFamily.InterNetwork.Equals(ip.AddressFamily))
               {
                   ipaddr = ip;
               }

           }
           return ipaddr;
       }

       //监听端口
       private void ListenClient()
       {

           byte[] buffer = null;
          
           IPAddress    localIP = GetIPAddress();
           TcpListener listener = new TcpListener(localIP, localPort);//用本地IP和端口实例化Listener  
           listener.Start();//开始监听  
           try
           {
               Task.Factory.StartNew(() =>  //线程执行任务
               {
                   while (true)
                   {
                       CReceive creceive = new CReceive();
                       client = listener.AcceptTcpClient();//接受一个Client  
                       buffer = new byte[client.ReceiveBufferSize];
                       creceive.RemoteIP = (client.Client.RemoteEndPoint as IPEndPoint).Address;
                       stream = client.GetStream();//获取网络流  
                       stream.Read(buffer, 0, buffer.Length);//读取网络流中的数据  
                       creceive.ReceiveString = Encoding.Default.GetString(buffer).Trim('\0');//转换成字符串 
                      

                       stream.Close();//关闭流  
                       client.Close();//关闭Client  


                       Receive_Event(creceive, null);//触发接收事件
                       Thread.Sleep(100);
                   }

               });
           }
           catch (Exception ex){
               MessageBox.ShowTip(ex.ToString());
           
           }
       }

       //连接客户端
       private bool ConnectClient(IPAddress remoteIP)
       {
              
               client = new TcpClient();//实例化TcpClient  
               try
               {   
                  

                   client.Connect(remoteIP, remotePort);//连接远程主机  
                   return true;
               }
               catch (System.Exception ex)
               {
                   Error_Event(TCPErr.ConnectErr, null);
                   client.Close();
                   return false;
               }
 

       }

       private void SendToClient(IPAddress remoteIP,  string sendString)
       {

               if (ConnectClient(remoteIP))
               {
                   try
                   {

                       byte[] sendData = null;//要发送的字节数组  
                       sendData = Encoding.Default.GetBytes(sendString);//获取要发送的字节数组  
                       stream = client.GetStream();//获取网络流  
                       stream.Write(sendData, 0, sendData.Length);//将数据写入网络流  
                       stream.Close();//关闭网络流  
                       client.Close();//关闭客户端  

                   }
                   catch
                   {
                       Error_Event(TCPErr.TimerOutErr, null);
                       stream.Close();//关闭网络流  
                       client.Close();//关闭客户端  
                   }
               }
            
       }



       /// <summary>
       /// 利用IPAddress属性配合Ping进行远程Server的确认。
       /// </summary> www.it165.net
       /// <returns></returns>
       int timeout = 20;//设置超时时间
       public bool ByPing(IPAddress IPv4Address)
       {
           IPAddress tIP = IPv4Address;
           Ping tPingControl = new Ping();
           PingReply tReply = tPingControl.Send(tIP, timeout);
           tPingControl.Dispose();
           if (tReply.Status != IPStatus.Success)
               return false;
           else
               return true;
       }
       public enum TCPErr { ConnectErr, TimerOutErr, OtherErr }

   }
}

public class CReceive
{
    public string ReceiveString { get; set; }
    public IPAddress RemoteIP { get; set; }

}

public class CSend
{
    public CSend( IPAddress ip,string s)
    {
     
        RemoteIP = ip;
        SendString = s;
    }
    public string SendString { get; set; }
    public IPAddress RemoteIP { get; set; }

}