using System.Net.Sockets;

namespace Server
{
    internal class UserInfo
    {
        public UserInfo(string v, Socket sock)
        {
        }

        public bool isManager { get; internal set; }
    }
}