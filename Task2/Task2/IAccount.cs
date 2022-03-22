using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal interface IAccount
    {
        public bool PasswordChecker(string pass);
        public void ShowInfo();
    }
}
