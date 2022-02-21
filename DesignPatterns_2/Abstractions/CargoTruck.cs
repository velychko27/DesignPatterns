namespace DesignPatterns.Abstractions
{
    public abstract class CargoTruck : Vehicle
    {
        public int CargoLoad { get; set; }

        public CargoTruck(int maxSpeed, double engineCapacity, string transmission) : 
            base(maxSpeed, engineCapacity, transmission)
        {

        }
    }
}
