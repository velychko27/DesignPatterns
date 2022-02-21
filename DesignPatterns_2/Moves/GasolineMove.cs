using DesignPatterns.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Moves
{
    public class GasolineMove : IMovable
    {
        public void Drive()
        {
            Console.WriteLine("Vehicle is driving using gasoline transmission.");
        }
    }
}
