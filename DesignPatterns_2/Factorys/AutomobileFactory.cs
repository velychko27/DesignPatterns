using DesignPatterns.Abstractions;
using DesignPatterns.Vehicles;

namespace DesignPatterns.Factorys
{
    public class AutomobileFactory : AbstractFactory
    {
        public AutomobileFactory(string factoryName) : base(factoryName) { }

        public override Car BuildVehicle(int maxSpeed, double engineCapacity, string transmission) =>
            new Car(maxSpeed, engineCapacity, transmission);
    }
}
