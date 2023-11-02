using info_class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class server
    {
        List<LecturRoom> lecturRooms;
        public server()
        {
            lecturRooms = new List<LecturRoom>();

            RunServer();
            Console.ReadLine();
        }
        Socket sock;

        public async void RunServer()
        {
            int BUFF_SIZE = 1024;
            TcpListener server = new TcpListener(IPAddress.Any, 7000);

            server.Start();

            Console.WriteLine("서버를 실행합니다.");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                Console.WriteLine("접속완료");
                IPEndPoint ipep = (IPEndPoint)client.Client.RemoteEndPoint;

                NetworkStream stream = client.GetStream();
                byte[] byteData = new byte[1024];

                client.GetStream().Read(byteData, 0, byteData.Length);
                //StreamReader sr = new StreamReader(client.GetStream());

                string ReceiveMsg = Encoding.Default.GetString(byteData);
                //string ReceiveMsg = sr.ReadLine();
                Console.WriteLine(ReceiveMsg);
                string[] splited = ReceiveMsg.Split(';');

                if (splited[0] == "Creat")
                {
                    Console.WriteLine(string.Format("Recv : {0};{1};", splited[0], splited[1]));

                    string Roomcode = CreateNewRoomcode();

                    sock = client.Client;

                    UserInfo user = new UserInfo(splited[1], sock);
                    user.isManager = true;

                    LecturRoom room = new LecturRoom(Roomcode);
                    room.AddUser(user);

                    lecturRooms.Add(room);

                    Console.WriteLine(string.Format("Send: CreatComplete;[0];", room.LectureCode));

                    byte[] msg = Encoding.Default.GetBytes(string.Format("CreatComplete;[0];", room.LectureCode));
                    sock.Send(msg);

                }
                else if (splited[0] == "Join")
                {
                    Console.WriteLine(string.Format("Send: {0};{1};{2};", splited[0], splited[1], splited[2]));

                    string RoomCode = splited[2];

                    Socket sock = client.Client;

                    UserInfo user = new UserInfo(splited[1], sock);

                    bool find = false;
                    for (int i = 0; i < lecturRooms.Count; i++)
                    {
                        if (lecturRooms[i].LectureCode == RoomCode)
                        {
                            find = true;
                            lecturRooms[i].AddUser(user);
                            break;
                        }
                    }

                    if (find)
                    {
                        Console.WriteLine(string.Format("Send: JoinComplete;{0};", RoomCode));

                        byte[] msg = Encoding.Default.GetBytes(string.Format("JoinComplete;{0};", RoomCode));
                        sock.Send(msg);
                    }
                    else
                    {
                        Console.WriteLine("Send: JoinFailed;");

                        byte[] msg = Encoding.Default.GetBytes(string.Format("JoinFailed;"));
                        sock.Send(msg);
                    }
                }
                
            }
        }
        public void Receive()
        {
            while (sock.Connected)
            {
                try
                {
                    byte[] data = info_Class.ServerPacket();

                    if (data == null)
                        continue;

                    BinaryFormatter bf = new BinaryFormatter();
                    ClientPacket clientPacket = (ClientPacket)bf.DeSerialize(data);

                    if (ClientData == null)
                        continue;

                    //roomInterface.BroadCast(data, UserID);
                }
                catch
                {
                    Console.WriteLine("Receive Exception {0}", Ex.Message);
                }
                //패킷 수신 예정
            }
        }

        private string CreateNewRoomcode()
        {
            throw new NotImplementedException();
        }
    }
}
