using DesignPatterns.Abstractions;
using System;

namespace DesignPatterns.Vehicles
{
    public class Truck : CargoTruck, IMovable
    {
        public Truck(int maxSpeed, double engineCapacity, string transmission) :
            base(maxSpeed, engineCapacity,transmission)
        {
            Console.WriteLine($"Truck has been built.");
        }

        public override int GetPrice() => 45500;

        public override void Drive()
        {
            Movable.Drive();
        }
    }
}
