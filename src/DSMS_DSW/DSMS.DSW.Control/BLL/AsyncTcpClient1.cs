using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace AsyncTcpClient
{
   public class AsyncTcpClient1
    {
        //是否正常退出
        private bool isExit = false;
        private TcpClient client;
        private BinaryReader br;
        private BinaryWriter bw;
        BackgroundWorker connectWork = new BackgroundWorker();
        private string serverIP = "192.168.1.200";

        public delegate void ReceiveMessage(string receiveString); //接收委托
        public ReceiveMessage ReceiveMes;

        public AsyncTcpClient1()
        {
            connectWork.DoWork += new DoWorkEventHandler(connectWork_DoWork);
            connectWork.RunWorkerCompleted += new RunWorkerCompletedEventHandler(connectWork_RunWorkerCompleted);
            connectWork.RunWorkerAsync();
        }


        /// <summary>
        /// 异步方式与服务器进行连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void connectWork_DoWork(object sender, DoWorkEventArgs e)
        {
            client = new TcpClient();
            IAsyncResult result = client.BeginConnect(serverIP, 8889, null, null);
            while (!result.IsCompleted)
            {
                Thread.Sleep(100);
            }
            try
            {
                client.EndConnect(result);
                e.Result = "success";
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
                return;
            }
        }

        /// <summary>
        /// 异步方式与服务器完成连接操作后的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void connectWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result.ToString() == "success")
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
                if (MessageBox.Show("连接失败" + e.Result) == DialogResult.OK)
                {
                    connectWork.RunWorkerAsync();//重新连接
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
                            connectWork.RunWorkerAsync();//重新连接
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
            Thread t = new Thread(FinishAsyncSendMessage);
            t.IsBackground = true;
            t.Start(states);
        }

        /// <summary>
        /// 处理接收的服务端数据
        /// </summary>
        /// <param name="obj"></param>
        private void FinishAsyncSendMessage(object obj)
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
