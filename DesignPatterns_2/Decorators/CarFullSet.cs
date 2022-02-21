using DesignPatterns.Abstractions;
using DesignPatterns.Moves;
using DesignPatterns.Vehicles;
using DesignPatterns_2.Abstractions;
using System;

namespace DesignPatterns_2.Vehicles
{
    public class CarFullSet : CarDecorator
    {
        public CarFullSet(Car car) : base(car)
        {
            Console.WriteLine("Air conditioner and Airbag have been installed to your car.");
        }
        public override void Drive() => base.Drive();

        public override int GetPrice() => base.GetPrice() + 3000;
    }
}
