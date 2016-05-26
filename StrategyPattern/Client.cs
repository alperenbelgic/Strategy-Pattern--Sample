using TeslaCarApplicationLibrary.Breaks;
using TeslaCarApplicationLibrary.SteeringWheels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCarApplicationLibrary
{
    public class Client
    {
        public static void Main()
        {
            var model3 = new Model3(new EasySteeringWheel(), new DefaultBreak());
            model3.Steer();
            model3.Brake();

            model3.SetSteeringWheel(new DefaultSteeringWheel());
            model3.Steer();

            model3.SetBreak(new RainBreak());
            model3.Brake();

            model3.SetSteeringWheel(new HardSteeringWheel());
            model3.Steer();

            Console.ReadKey();
        }
    }
}
