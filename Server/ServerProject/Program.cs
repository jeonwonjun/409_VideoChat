using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerProject
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
            Application.Run(new Server());
        }
    }
}

namespace ServerSocket
{
    class Program
    {
        
        Socket mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        
        void Main(String[] args)
        {


            IPAddress addr = IPAddress.Parse("localgost");
            IPEndPoint ep = new IPEndPoint(addr, 9999);
            mainSock.Bind(ep);

            mainSock.Listen(10);
         
            

            public class AsyncObject {
                public byte[] Buffer;
                public Socket WorkingSocket;
                public readonly int BufferSize;
                public AsyncObject(int bufferSize)
                {
                    BufferSize = bufferSize;
                    Buffer = new byte[BufferSize];
                }

                public void ClearBuffer()
                {
                    Array.Clear(Buffer, 0, BufferSize);
                }
            }
           
            void AcceptCallback(IAsyncResult ar)
            {
                Socket clientSocket = mainSock.EndAccept(ar);

                mainSock.BeginAccept(AcceptCallback, null);

                AsyncObject obj = new AsyncObject(4096);
                obj.WorkingSocket = clientSocket;
                clientSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);

            }

            void DataReceived(IAsyncResult ar)
            {
            // BeginReceive에서 추가적으로 넘어온 데이터를 AsyncObject 형식으로 변환한다.
                AsyncObject obj = (AsyncObject)ar.AsyncState;

            // 클라이언트가 보낸 데이터는 obj.Buffer에 바이트 형식으로 저장된다.
            // 따라서 이 데이터는 System.Text.Encoding 클래스의 GetString 함수를 이용하여 문자열로
            // 변환해야 사용이 가능하다.
                string text = System.Text.Encoding.UTF8.GetString(obj.Buffer);

            // 데이터를 받은 후엔 다시 버퍼를 비워주고 같은 방법으로 수신을 대기한다.
                obj.ClearBuffer();

            // 수신 대기
            // AcceptCallback 함수에서의 client와 obj.WorkingSocket은 동일한 소켓 개체이다!
                obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
            }                        
        }
    }
}
