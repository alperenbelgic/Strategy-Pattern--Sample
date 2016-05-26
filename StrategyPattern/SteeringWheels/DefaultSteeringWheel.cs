using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCarApplicationLibrary.SteeringWheels
{
    public class DefaultSteeringWheel : ISteeringWheel
    {
        public void Steer()
        {
            Console.WriteLine("Steer: Steered normally.");
        }
    }
}
