using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCarApplicationLibrary.Breaks
{
    public class DefaultBreak : IBreak
    {
        public void Break()
        {
            Console.WriteLine("Break: Default break used.");
        }
    }
}
