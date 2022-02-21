namespace DesignPatterns.Abstractions
{
    public abstract class Automobile : Vehicle
    {
        public int SeatCapacity { get; set; }

        public Automobile(int maxSpeed, double engineCapacity, string transmission) : 
            base(maxSpeed, engineCapacity, transmission)
        {

        }
    }
}
