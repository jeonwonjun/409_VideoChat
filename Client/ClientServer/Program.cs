using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServer
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClientForm());
        }
    }

    static void Main(string[] args)
    {
        

        Socket mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string address = "localhost";
        int port = 12345;
        mainSock.Connect(address, port);

        if (mainSock.Connected)
            Console.WriteLine("서버에 연결되었습니다.");

        string message = string.Empty;

        while((message = Console.ReadLine()) != "x")
        {
            byte[] buff = Encoding.UTF8.GetBytes(message);
            mainSock.Send(buff);
        }

        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate _textAppender;

        void AppendText(Control ctrl, string s)
        {

            if (_textAppender == null) _textAppender = new AppendTextDelegate(AppendText);
            if (ctrl.InvokeRequired) ctrl.Invoke(_textAppender, ctrl, s);
            else
            {
                string source = ctrl.Text;
                ctrl.Text = source + Environment.NewLine + s;
            }
        }


        AsyncObject ao = new AsyncObject(4096);
        ao.WorkingSocket = mainSock;
        mainSock.BeginReceive(ao.Buffer, 0, ao.BufferSize, 0, DataReceived, ao);

        void DataReceived(IAsyncResult ar)
        {

            AsyncObject obj = (AsyncObject)ar.AsyncState;


            int received = obj.WorkingSocket.EndReceive(ar);

            if (received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }


            string text = Encoding.UTF8.GetString(obj.Buffer);


            string[] tokens = text.Split('\x01');
            string ip = tokens[0];
            string msg = tokens[1];


            AppendText(txtHistory, string.Format("[받음]{0}: {1}", ip, msg));


            obj.ClearBuffer();


            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }
        void OnSendData(object sender, EventArgs e)
        {
.
            if (!mainSock.IsBound)
            {
                MsgBoxHelper.Warn("서버가 실행되고 있지 않습니다!");
                return;
            }


            string tts = txtTTS.Text.Trim();
            if (string.IsNullOrEmpty(tts))
            {
                MsgBoxHelper.Warn("텍스트가 입력되지 않았습니다!");
                txtTTS.Focus();
                return;
            }


            IPEndPoint ip = (IPEndPoint)mainSock.LocalEndPoint;
            string addr = ip.Address.ToString();


            byte[] bDts = Encoding.UTF8.GetBytes(addr + '\x01' + tts);


            mainSock.Send(bDts);


            AppendText(txtHistory, string.Format("[보냄]{0}: {1}", addr, tts));
            txtTTS.Clear();
        }
    }

    internal class AsyncObject
    {
        public AsyncObject(int v)
        {
        }
    }
}
