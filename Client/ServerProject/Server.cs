using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ServerProject
{
    public partial class Server : Form
    {
        void RunServer()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 7000);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            server.Listen(7);

            Console.WriteLine("Run Server");

            try
            {
                while (true)
                {
                    Socket client = server.Accept();
                    Client tmp = new Client(client);

                    Console.Write("Client Conneted : ");
                    Console.WriteLine(((IPEndPoint)client.RemoteEndPoint).Address.ToString());

                    client.Add(tmp);
                }
            }
            finally
            {
                StopServer();
            }

    }

        
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace socksrv
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1) 소켓 객체 생성 (TCP 소켓)
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // (2) 포트에 바인드
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 9999);
            sock.Bind(ep);

            // (3) 포트 Listening 시작
            sock.Listen(10);

            // (4) 연결을 받아들여 새 소켓 생성 (하나의 연결만 받아들임)
            Socket clientSock = sock.Accept();

            byte[] buff = new byte[8192];
            while (!Console.KeyAvailable) // 키 누르면 종료
            {
                // (5) 소켓 수신
                int n = clientSock.Receive(buff);

                string data = Encoding.UTF8.GetString(buff, 0, n);
                Console.WriteLine("클라이언트가 접속하였습니다.");

                // (6) 소켓 송신
                clientSock.Send(buff, 0, n, SocketFlags.None);  // echo
            }

            // (7) 소켓 닫기
            clientSock.Close();
            sock.Close();
        }
    }
}
