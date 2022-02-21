using DesignPatterns.Abstractions;
using System;

namespace DesignPatterns.Vehicles
{
    public class Car : Automobile, IMovable
    {
        public Car(int maxSpeed, double engineCapacity, string transmission) :
            base(maxSpeed, engineCapacity, transmission)
        {
            Console.WriteLine($"Car has been built.");
        }

        public override void Drive()
        {
            Movable.Drive();
        }
    }
}
