using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class User:IAccount
    {
        public User(string email,string pass)
        {
            this.Email = email;
            this.Password = pass;
        }
        public string FullName;
        public string Email;
        private string _password;
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    this._password = value;
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"User Name : {this.FullName}, User Email : {this.Email}");
        }
        public bool PasswordChecker(string pass)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;
            if (pass.Length >= 8)
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (char.IsUpper(pass[i]))
                    {
                        hasUpper = true;
                    } else if (char.IsLower(pass[i]))
                    {
                        hasLower = true;    
                    } else if (char.IsDigit(pass[i]))
                    {
                        hasDigit = true;
                    }
                    if(hasDigit && hasUpper && hasLower)
                    {
                        return true;
                    }
                }
                return false;
            } else
            {
                return false;
            }
        }
    }
}

