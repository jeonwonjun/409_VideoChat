using System;

namespace Server
{
    internal class LecturRoom
    {
        public LecturRoom(string roomcode)
        {
        }

        public string LectureCode { get; internal set; }

        internal void AddUser(UserInfo user)
        {
            throw new NotImplementedException();
        }
    }
}