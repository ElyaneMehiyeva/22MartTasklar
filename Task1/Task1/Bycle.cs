using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Bycle:Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Bycle Color : {Color}, Bycle Brand : {Brand}, Bycle Millage : {Millage}");
        }
    }
}

