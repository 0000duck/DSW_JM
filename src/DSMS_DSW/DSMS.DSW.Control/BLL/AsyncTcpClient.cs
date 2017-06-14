using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
namespace AsyncTcpClient
{
  public  class AsyncTcpClient
    {
        //是否正常退出
        private bool isExit = false;
        private bool IsConnected = false;

        private TcpClient client;
        private BinaryReader br;
        private BinaryWriter bw;
   
        private string serverIP = "192.168.1.200";
        private int port = 8889;
        public delegate void ReceiveMessage(string receiveString); //接收委托
        public ReceiveMessage ReceiveMes;


        private event EventHandler ConnectWork_DoWork;
        private event EventHandler ConnectWork_RunWorkerCompleted;
        private event EventHandler FinishAsyncSendMessage; 


        public AsyncTcpClient()
        {
            
            ConnectWork_DoWork += connectWork_DoWork;
            ConnectWork_RunWorkerCompleted += connectWork_RunWorkerCompleted;
            FinishAsyncSendMessage += finishAsyncSendMessage;
            ConnectWork_DoWork(this, null);
        }


        /// <summary>
        /// 异步方式与服务器进行连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void connectWork_DoWork(object sender, EventArgs e)
        {
              client = new TcpClient();
             IPEndPoint iep = new IPEndPoint(IPAddress.Parse(serverIP), port);
             EndPoint Remote = (EndPoint)(iep);
           IAsyncResult result = client.Client.BeginConnect(Remote, null, null);


            while (!result.IsCompleted)
           {
               Thread.Sleep(100);
           }
           try
           {
               client.Client.EndConnect(result);

               IsConnected = true;
               //e.Result = "success";
           }
           catch (Exception ex)
           {
               //e.Result = ex.Message;
               IsConnected = false;
               return;
           }
            ConnectWork_RunWorkerCompleted(this, null);
        }

        /// <summary>
        /// 异步方式与服务器完成连接操作后的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void connectWork_RunWorkerCompleted(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                //获取网络流
                NetworkStream networkStream = client.GetStream();
                //将网络流作为二进制读写对象
                br = new BinaryReader(networkStream);
                bw = new BinaryWriter(networkStream);
                Thread threadReceive = new Thread(new ThreadStart(ReceiveData));
                threadReceive.IsBackground = true;
                threadReceive.Start();
            }
            else
            {
                if (MessageBox.Show("连接失败!") == DialogResult.OK)
                {
                    ConnectWork_DoWork(this, null);
                }
            }
        }



        /// <summary>
        /// 处理接收的服务器收据
        /// </summary>
        private void ReceiveData()
        {
            string receiveString = null;
            while (!isExit)
            {
                ReceiveMessageDelegate d = new ReceiveMessageDelegate(receiveMessage);
                IAsyncResult result = d.BeginInvoke(out receiveString, null, null);
                //使用轮询方式来盘点异步操作是否完成
                while (!result.IsCompleted)
                {
                    if (isExit)
                        break;
                    Thread.Sleep(250);
                }
                //获取Begin方法的返回值所有输入/输出参数
                d.EndInvoke(out receiveString, result);
                if (receiveString == null)
                {
                    if (!isExit)
                        if (MessageBox.Show("与服务器失去联系") == DialogResult.OK)
                        {
                            ConnectWork_DoWork(this, null);//重新连接
                        }
                    break;
                }


                // 接收到的数据处理
                ReceiveMes(receiveString);
               

            }
        }

        /// <summary>
        /// 发送信息状态的数据结构
        /// </summary>
        private struct SendMessageStates
        {
            public SendMessageDelegate d;
            public IAsyncResult result;
        }

        /// <summary>
        /// 异步向服务器发送数据
        /// </summary>
        /// <param name="message"></param>
        public void AsyncSendMessage(string message)
        {
            SendMessageDelegate d = new SendMessageDelegate(SendMessage);
            IAsyncResult result = d.BeginInvoke(message, null, null);
            while (!result.IsCompleted)
            {
                if (isExit)
                    return;
                Thread.Sleep(50);
            }
            SendMessageStates states = new SendMessageStates();
            states.d = d;
            states.result = result;
            FinishAsyncSendMessage(states,null);
            //Thread t = new Thread(new ThreadStart(FinishAsyncSendMessage));
            //t.IsBackground = true;
            //t.Start();
            
        }

        ///// <summary>
        ///// 处理接收的服务端数据
        ///// </summary>
        ///// <param name="obj"></param>
        //private void FinishAsyncSendMessage(object obj)
        //{
        //    SendMessageStates states = (SendMessageStates)obj;
        //    states.d.EndInvoke(states.result);
        //}


        /// <summary>
        /// 处理接收的服务端数据
        /// </summary>
        /// <param name="obj"></param>
        private void finishAsyncSendMessage(object obj, EventArgs e)
        {
            SendMessageStates states = (SendMessageStates)obj;
            states.d.EndInvoke(states.result);
        }


        delegate void SendMessageDelegate(string message);
        /// <summary>
        /// 向服务端发送数据
        /// </summary>
        /// <param name="message"></param>
        private void SendMessage(string message)
        {
            try
            {
                bw.Write(message);
                bw.Flush();
            }
            catch
            {
                MessageBox.Show("发送失败");
            }
        }

        delegate void ConnectServerDelegate();
        /// <summary>
        /// 连接服务器
        /// </summary>
        private void ConnectServer()
        {
            client = new TcpClient(serverIP, 8889);
        }

        delegate void ReceiveMessageDelegate(out string receiveMessage);
        /// <summary>
        /// 读取服务器发过来的信息
        /// </summary>
        /// <param name="receiveMessage"></param>
        private void receiveMessage(out string receiveMessage)
        {
            receiveMessage = null;
            try
            {
                receiveMessage = br.ReadString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Client_Dispose()
        {
            if (client != null)
            {
                isExit = true;
                br.Close();
                bw.Close();
                client.Close();
            }
        }

    }
}
