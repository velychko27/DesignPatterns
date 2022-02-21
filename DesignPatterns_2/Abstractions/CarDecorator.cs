using DesignPatterns.Abstractions;
using DesignPatterns.Moves;
using DesignPatterns.Vehicles;

namespace DesignPatterns_2.Abstractions
{
    public abstract class CarDecorator : Car
    {
        protected Car car;

        public CarDecorator(Car car) : base(car.MaxSpeed, car.EngineCapacity, car.Transmission)
        {
            this.car = car;
        }
    }
}
