using DesignPatterns.Abstractions;
using DesignPatterns.Vehicles;
using System;

namespace DesignPatterns.Factorys
{
    public class CargoTruckFactory : AbstractFactory
    {
        public CargoTruckFactory(string factoryName) : base(factoryName)
        {
            Console.WriteLine($"{factoryName} is building the truck.");
        }

        public override Truck BuildVehicle(int maxSpeed, double engineCapacity, string transmission) =>
            new Truck(maxSpeed, engineCapacity, transmission);
    }
}
