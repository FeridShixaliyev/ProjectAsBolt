using System;
using System.Collections.Generic;
using System.Text;

namespace Bolt
{
    class User
    {
        public User(string username,string password)
        {
            Id = _id++;
            NickName = username;
            Password = password;
        }
        private static int _id=1;
        public int Id { get; }
        public string NickName { get; set; }
        public string Password { get; set; }

        public string ShowInfo()
        {
            return $"\nId: {Id}  -  NickName: {NickName} - Password: {Password}";
        }
    }
}
