using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCarApplicationLibrary
{
    public abstract class Car
    {
        protected ISteeringWheel SteeringWheel { get; set; }

        protected IBreak BrakeInstance { get; set; }

        public Car(ISteeringWheel steeringWheel, IBreak breakInstance)
        {
            SetSteeringWheel(steeringWheel);
            SetBreak(breakInstance);
        }

        public void SetSteeringWheel(ISteeringWheel steeringWheel)
        {
            this.SteeringWheel = steeringWheel;
        }

        public void SetBreak(IBreak breakInstance)
        {
            this.BrakeInstance = breakInstance;
        }

        public void Steer()
        {
            this.SteeringWheel.Steer();
        }

        public void Brake()
        {
            this.BrakeInstance.Break();
        }

    }
}
