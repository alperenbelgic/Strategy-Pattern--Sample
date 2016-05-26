using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCarApplicationLibrary.SteeringWheels
{
    public class EasySteeringWheel : ISteeringWheel
    {
        public void Steer()
        {
            Console.WriteLine("Steer: Steered easily.");
        }
    }
}
