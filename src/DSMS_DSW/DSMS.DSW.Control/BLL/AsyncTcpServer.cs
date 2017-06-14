using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DSMS.DSW.Control.BLL
{
   public class AsyncTcpServer
    {

        /// <summary>
        /// 保存连接的所有用户
        /// </summary>
       private List<TcpUser> userList = new List<TcpUser>();
        /// <summary>
        /// 使用的本机IP地址
        /// </summary>
        IPAddress localAddress = IPAddress.Parse(Golbal.LocalIP);
        /// <summary>
        /// 监听端口
        /// </summary>
        private const int port = 8889;
        private TcpListener myListener;

        /// <summary>
        /// 是否正常退出所有接收线程
        /// </summary>
       bool isExit = false;
       public AsyncTcpServer()
       {
           myListener = new TcpListener(localAddress, port);
           myListener.Start();
 
           Thread myThread = new Thread(ListenClientConnect);
           myThread.Start();

        }

       /// <summary>
       /// 监听客户端请求
       /// </summary>
       private void ListenClientConnect()
       {
           TcpClient newClient = null;
           while (true)
           {
               ListenClientDelegate d = new ListenClientDelegate(ListenClient);
               IAsyncResult result = d.BeginInvoke(out newClient, null, null);
               //使用轮询方式来判断异步操作是否完成
               while (result.IsCompleted == false)
               {
                   if (isExit)
                       break;
                   Thread.Sleep(250);
               }
               //获取Begin 方法的返回值和所有输入/输出参数
               d.EndInvoke(out newClient, result);
               if (newClient != null)
               {
                   //每接受一个客户端连接，就创建一个对应的线程循环接收该客户端发来的信息
                   TcpUser user = new TcpUser(newClient);
                   Thread threadReceive = new Thread(ReceiveData);
                   threadReceive.Start(user);
                   userList.Add(user);
               }
               else
               {
                   break;
               }
           }
       }


       private void ReceiveData(object userState)
       {
           TcpUser user = (TcpUser)userState;
           TcpClient client = user.client;
           while (!isExit)
           {
               string receiveString = null;
               ReceiveMessageDelegate d = new ReceiveMessageDelegate(ReceiveMessage);
               IAsyncResult result = d.BeginInvoke(user, out receiveString, null, null);
               //使用轮询方式来判断异步操作是否完成
               while (!result.IsCompleted)
               {
                   if (isExit)
                       break;
                   Thread.Sleep(250);
               }
               //获取Begin方法的返回值和所有输入/输出参数
               d.EndInvoke(out receiveString, result);
               if (receiveString == null)
               {
                   if (!isExit)
                   { 
                       RemoveUser(user);
                   }
                   break;
               }

               AsyncSendToClient(user, receiveString);
           }
       }


       private delegate void ListenClientDelegate(out TcpClient client);

       /// <summary>
       /// 接受挂起的客户端连接请求
       /// </summary>
       /// <param name="newClient"></param>
       private void ListenClient(out TcpClient newClient)
       {
           try
           {
               newClient = myListener.AcceptTcpClient();
           }
           catch
           {
               newClient = null;
           }
       }



       delegate void ReceiveMessageDelegate(TcpUser user, out string receiveMessage);
       /// <summary>
       /// 接收客户端发来的信息
       /// </summary>
       /// <param name="user"></param>
       /// <param name="receiveMessage"></param>
       private void ReceiveMessage(TcpUser user, out string receiveMessage)
       {
           try
           {
               receiveMessage = user.br.ReadString();
           }
           catch (Exception ex)
           {
               receiveMessage = null;
           }
       }

       /// <summary>
       /// 异步发送信息给所有客户
       /// </summary>
       /// <param name="user"></param>
       /// <param name="message"></param>
       public void AsyncSendToAllClient(string message)
       {

           for (int i = 0; i < userList.Count; i++)
           {
               TcpClient tcp = userList[i].client;
               AsyncSendToClient(userList[i], ((IPEndPoint)tcp.Client.RemoteEndPoint).Address.ToString());
           }
       
       }

       /// <summary>
       /// 异步发送message给user
       /// </summary>
       /// <param name="user"></param>
       /// <param name="message"></param>
       private void AsyncSendToClient(TcpUser user, string message)
       {
           SendToClientDelegate d = new SendToClientDelegate(SendToClient);
           IAsyncResult result = d.BeginInvoke(user, message, null, null);
           while (result.IsCompleted == false)
           {
               if (isExit)
                   break;
               Thread.Sleep(250);
           }
           d.EndInvoke(result);
       }




       private delegate bool SendToClientDelegate(TcpUser user, string message);
       /// <summary>
       /// 发送message给user
       /// </summary>
       /// <param name="user"></param>
       /// <param name="message"></param>
       private bool SendToClient(TcpUser user, string message)
       {
           try
           {
               //将字符串写入网络流，此方法会自动附加字符串长度前缀
               user.bw.Write(message);
               user.bw.Flush();
               return true;
           }
           catch
           {
               return false;
           }
       }

       /// <summary>
       /// 移除用户
       /// </summary>
       /// <param name="user"></param>
       private void RemoveUser(TcpUser user)
       {
           userList.Remove(user);
           user.Close();
       }
    }
}
