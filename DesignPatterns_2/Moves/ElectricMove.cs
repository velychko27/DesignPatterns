using DesignPatterns.Abstractions;
using System;

namespace DesignPatterns.Moves
{
    public class ElectricMove : IMovable
    {
        public void Drive()
        {
            Console.WriteLine("Vehicle is driving using electrical transmission.");
        }
    }
}
