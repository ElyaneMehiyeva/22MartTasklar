using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Vehicle Color : {this.Color}, Vehicle Brand : {this.Brand}, Vehicle Millage : {this.Millage}");
        }
        public abstract void Drive(double km);
    }
}
