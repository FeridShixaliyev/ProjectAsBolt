using System;
using System.Collections.Generic;
using System.Text;

namespace Bolt
{
    class Admin
    {
        public Admin(string username,string password)
        {
            Id = _id++;
            UserName = username;
            Password = password;
        }
        private static int _id;
        private string _userName;
        private string _password;
        public int Id { get; }
        public string UserName
        {
            get => _userName;
            set
            {
                if (value.Length > 2 && value.Length < 31)
                    _userName = value;
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && CheckPassword(value))
                    _password = value;
            }
        }
        private List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public List<User> GetUserList()
        {
            return users;
        }
        public bool CheckPassword(string pass)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;
            foreach (var i in pass)
            {
                if (char.IsUpper(i))
                    isUpper = true;
                else if (char.IsLower(i))
                    isLower = true;
                else if (char.IsDigit(i))
                    isDigit = true;

                if (isDigit && isLower && isUpper)
                    return true;
            }
            return false;
        }
    }
}
