using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCarApplicationLibrary
{
    public class Model3 : Car
    {
        public Model3(ISteeringWheel steeringWheel, IBreak breakInstance) : base(steeringWheel, breakInstance)
        {
        }
    }
}
