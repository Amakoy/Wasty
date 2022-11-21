using System;
using System.Collections.Generic;
using System.Text;

namespace wasty
{
    class Admin
    {
        private string _accountID;
        private string _userName;
        private string _password;
        private string _fullName;
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string AccountID {
            get { return _accountID; }
            set { _accountID = value; } 
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

    }
}
