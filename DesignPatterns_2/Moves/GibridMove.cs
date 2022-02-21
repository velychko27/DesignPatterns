using DesignPatterns.Abstractions;
using System;

namespace DesignPatterns.Moves
{
    public class GibridMove : IMovable
    {
        public void Drive()
        {
            Console.WriteLine("Vehicle is driving using electrical transmission. If speed more than 40 km per hour, gasoline transmission is used.");
        }
    }
}
