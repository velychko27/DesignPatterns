using DesignPatterns.Abstractions;
using DesignPatterns.Vehicles;
using System;

namespace DesignPatterns.Factorys
{
    public class AutomobileFactory : AbstractFactory
    {
        public AutomobileFactory(string factoryName) : base(factoryName)
        {
            Console.WriteLine($"{factoryName} is building the car.");
        }

        public override Car BuildVehicle(int maxSpeed, double engineCapacity, string transmission) =>
            new Car(maxSpeed, engineCapacity, transmission);
    }
}
