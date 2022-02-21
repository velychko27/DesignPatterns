using DesignPatterns.Moves;

namespace DesignPatterns.Abstractions
{
    public abstract class Vehicle
    {
        public IMovable Movable { get; set; }
        public int MaxSpeed { get; set; }
        public double EngineCapacity { get; set; }
        public string Transmission { get; set; }

        public abstract int GetPrice();

        public abstract void Drive();

        public Vehicle(int maxSpeed, double engineCapacity, string transmission)
        {
            this.Movable = new GibridMove();
            this.MaxSpeed = maxSpeed;
            this.EngineCapacity = engineCapacity;
            this.Transmission = transmission;
        }
    }
}
