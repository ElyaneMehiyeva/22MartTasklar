using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User ali = new User("ali311@gmail.com", "Password900")
            {
                FullName = "Ali Huroglu",
            };

            ali.ShowInfo();

            Console.WriteLine(ali.PasswordChecker("Password900"));// True
            Console.WriteLine(ali.PasswordChecker("password900"));// False
            Console.WriteLine(ali.PasswordChecker("Passwordrty"));// False
            Console.WriteLine(ali.PasswordChecker("PASSWORD900"));// False
            // The End
        }
    }
}
