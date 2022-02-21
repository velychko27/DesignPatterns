using DesignPatterns.Abstractions;
using DesignPatterns.Vehicles;

namespace DesignPatterns.Factorys
{
    public class CargoTruckFactory : AbstractFactory
    {
        public CargoTruckFactory(string n) : base(n) { }

        public override Truck BuildVehicle(int maxSpeed, double engineCapacity, string transmission) =>
            new Truck(maxSpeed, engineCapacity, transmission);
    }
}
