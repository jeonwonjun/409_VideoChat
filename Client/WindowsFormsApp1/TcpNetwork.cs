using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace GUI
{
    public interface NetInterface
    {
        void Connect();
        void DisConnect();
        void ReceiveStop();
        void SendMessage(string Msg);
        string ReceiveMessage();
        void ReceiveStart();
        void Receive();
    }
    class TcpNetwork : NetInterface
    {
        TcpClient client = null;
        Thread ReceiveTh;

        public NetInterface Interface
        {
            get
            {
                return this as NetInterface;
            }
        }
        public TcpNetwork()
        {

        }

        public void Connect()
        {
            client = new TcpClient(); //클라이언트 선언
            client.Connect("127.0.0.1", 7000); // IP, Port 지정
        }

        public void DisConnect()
        {
            ReceiveStop();
            if (client != null && client.Connected)
                client.Close();
        }

        public void ReceiveStop()
        {
            if (ReceiveTh != null && ReceiveTh.IsAlive)
            {
                ReceiveTh.Abort(); // 리시브 중단
            }
        }

        public void SendMessage(string Msg)
        {
            if (client == null)
            {
                return;
            }

            byte[] buffer = Encoding.Default.GetBytes(Msg); //문자열을 바이트배열로 변환
            client.GetStream().Write(buffer, 0, buffer.Length); // 
        }

        public string ReceiveMessage()
        {
            byte[] byteData = new byte[1024];

            client.GetStream().Read(byteData, 0, byteData.Length);

            string ReceiveMsg = Encoding.Default.GetString(byteData);

            return ReceiveMsg;
        }

        public void ReceiveStart()
        {
            if (ReceiveTh != null && ReceiveTh.IsAlive)
            {
                return;
            }
            ReceiveTh = new Thread(new ThreadStart(Receive));
            ReceiveTh.Start();
        }

        public void Receive()
        {
            while (client.Connected)
            {
                //패킷 수신 예정
            }
        }
    }
}
