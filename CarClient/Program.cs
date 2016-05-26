using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeslaCarApplicationLibrary;
using TeslaCarApplicationLibrary.Breaks;
using TeslaCarApplicationLibrary.SteeringWheels;

namespace CarClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var model3 = new Model3(new EasySteeringWheel(), new DefaultBreak());

            var form = new TeslaModel3_IO();
            form.Car = model3;
            form.ShowDialog();

            Console.ReadKey();
        }
    }
}
