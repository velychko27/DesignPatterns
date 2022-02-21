using DesignPatterns.Factorys;
using DesignPatterns.Moves;
using System;

namespace DesignPatterns_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mercedesFactory = new AutomobileFactory("Mercedes-Benz");
            var car = mercedesFactory.BuildVehicle(320, 2.5, "Automate");
            car.Drive();
            car.Movable = new ElectricMove();
            car.Drive();

            Console.WriteLine();

            var volvoCarsFactory = new CargoTruckFactory("Volvo Cars");
            var truck = volvoCarsFactory.BuildVehicle(250, 4.5, "Automate");
            truck.Drive();
            truck.Movable = new GasolineMove();
            truck.Drive();
        }
    }
}
