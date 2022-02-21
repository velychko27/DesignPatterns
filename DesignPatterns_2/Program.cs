using DesignPatterns.Factorys;
using DesignPatterns.Moves;
using DesignPatterns_2.Vehicles;
using System;

namespace DesignPatterns_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mercedesFactory = new AutomobileFactory("Mercedes-Benz");
            var car = mercedesFactory.BuildVehicle(320, 2.5, "Automate");
            Console.WriteLine($"The price is: {car.GetPrice()}");

            car = new CarFullSet(car);
            Console.WriteLine($"The price is: {car.GetPrice()}");

            car.Drive();
            car.Movable = new GasolineMove();
            car.Drive();
        }
    }
}
