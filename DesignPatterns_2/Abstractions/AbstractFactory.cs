namespace DesignPatterns.Abstractions
{
    public abstract class AbstractFactory 
    {
        public string FactoryName { get; set; }

        public AbstractFactory(string factoryName)
        {
            this.FactoryName = factoryName;
        }
        public abstract Vehicle BuildVehicle(int maxSpeed, double engineCapacity, string transmission);
    }
}
