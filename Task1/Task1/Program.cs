using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("masin sayini daxil edin");
            int countCar = int.Parse(Console.ReadLine());
            Car[] cars = new Car[countCar];
            for (int i = 0; i < countCar; i++)
            {
                Console.WriteLine($"{i + 1} masinin rengi :");
                string color = Console.ReadLine();
                Console.WriteLine($"{i + 1} masinin brend adi :");
                string brand = Console.ReadLine();
                Console.WriteLine($"{i + 1} masinin millage deyeri :");
                double millage = double.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1} masinin benzin tutumu :");
                double fuelCapacity = double.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1} masinin benzini :");
                double currentFuel = double.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1} masinin 1km e serf etdiyi benzin :");
                double fuelFor1Km = double.Parse(Console.ReadLine());
                Car car = new Car()
                {
                    Color = color,
                    Brand = brand,
                    Millage = millage,
                    FuelCapacity = fuelCapacity,
                    CurrentFuel = currentFuel,
                    FuelFor1Km = fuelFor1Km,
                };
                cars[i] = car;
            }

            while (true)
            {
                Console.WriteLine("1.Masinlari millage - e gore filtirle\n2.Butun masinlari goster\n3.Prosesi bitir");
                string command = Console.ReadLine();
                if (command == "3")
                {
                    Console.WriteLine("Proses Bitdi!!");
                    break;
                }
                switch (command)
                {
                    case "1":
                        Console.WriteLine("Min Millage :");
                        double minMillage = double.Parse(Console.ReadLine());
                        Console.WriteLine("Max Millage :");
                        double maxMillage = double.Parse(Console.ReadLine());
                        Car[] filterCars = FilterForMillageValue(cars,minMillage,maxMillage);
                        Console.WriteLine("Filtirlendi :");
                        foreach (Car car in filterCars)
                        {
                            car.ShowInfo();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Butun Masinlar");
                        foreach (Car car in cars)
                        {
                            car.ShowInfo();
                        }
                        break;
                    default:
                        break;
                }
            }
           
        }
        static Car[] FilterForMillageValue(Car[] cars, double minMillage, double maxMillage)
        {
            int count = 0;
            foreach (Car car in cars)
            {
                if (car.Millage >= minMillage && car.Millage <= maxMillage)
                {
                    count++;
                }
            }
            Car[] newCars = new Car[count];
            int index = 0;
            foreach (Car car in cars)
            {
                if (car.Millage >= minMillage && car.Millage <= maxMillage)
                {
                    newCars[index] = car;
                    index++;
                }
            }
            return newCars;
        }
    }
}
