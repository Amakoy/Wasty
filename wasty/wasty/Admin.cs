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
        public string Name
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //methods
        public Boolean Login(string userName, string password)
        {
            //dummy login database
            if (userName == "Admin" & password == "Admin1010")
            {
                return true;
            }
            else if(userName == "User01" & password == "User01")
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
        public void ShowCustomer()
        {
            
        }
        public void AddCustomer()
        {
            // nama, email, nohp
        }
        public void RemoveCustomer()
        {

        }
        public void UpdateCustomer()
        {

        }

        public void ShowRecords()
        {

        }
    }
}
