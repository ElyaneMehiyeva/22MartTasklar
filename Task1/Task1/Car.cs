using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Car:Vehicle
    {
       
        private double _fuelCapacity;
        private double _currentFuel;
        private double _fuelFor1Km;

        public double FuelCapacity
        {
            get
            {
                return this._fuelCapacity;
            }
            set
            {
                if (value > 0)
                {
                    this._fuelCapacity = value;
                }
            }
        }
        public double CurrentFuel
        {
            get
            {
                return this._currentFuel;
            }
            set
            {
                if(value >=0 && value <= this.FuelCapacity) 
                {
                    this._currentFuel = value;
                }
            } 
        }
        public double FuelFor1Km
        {
            get
            {
                return this._fuelFor1Km;
            }
            set
            {
                if (value > 0)
                {
                    this._fuelFor1Km = value;
                }
            }
        }
        
       


        public override void Drive(double km)
        {
            
            double fuel = km * this.FuelFor1Km;
            if(this.CurrentFuel - fuel <= 0)
            {
                Console.WriteLine($"{km} km yola benzin catmir! Yada {km} km mesafeden sonra benzin bitir!");
            }else
            {                       
                this.CurrentFuel -= fuel;
                Millage = Millage + km;
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Car Color : {Color}, Car Brand : {Brand}, Car Millage : {Millage}, Car FuelCapacity :{this.FuelCapacity}, Car CurrentFuel : {this.CurrentFuel}, Car FuelFor1KM : {this.FuelFor1Km}");
        }
       
    }
}
