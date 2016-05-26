using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeslaCarApplicationLibrary;
using TeslaCarApplicationLibrary.Breaks;
using TeslaCarApplicationLibrary.SteeringWheels;

namespace CarClient
{

    public partial class TeslaModel3_IO : Form
    {
        public Car Car { get; set; }

        public TeslaModel3_IO()
        {
            InitializeComponent();
        }

        private void btnSteer_Click(object sender, EventArgs e)
        {
            Car.Steer();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            Car.Brake();
        }

        private void numericUpDownSpeed_Leave(object sender, EventArgs e)
        {
            // this logic probably should have been in Car class. 
            // In order to show the strategy pattern clearly, Car class contains minimum lines of codes.
            if (numericUpDownSpeed.Value < 30)
            {
                Car.SetSteeringWheel(new EasySteeringWheel());
            }
            else if (numericUpDownSpeed.Value < 60)
            {
                Car.SetSteeringWheel(new DefaultSteeringWheel());
            }
            else
            {
                Car.SetSteeringWheel(new HardSteeringWheel());
            }
        }

        private void cbIsRainy_CheckedChanged(object sender, EventArgs e)
        {
            // this logic might have been in Car class. 
            // In order to show the strategy pattern clearly, Car class contains minimum lines of codes.
            if (cbIsRainy.Checked)
            {
                Car.SetBreak(new RainBreak());
            }
            else
            {
                Car.SetBreak(new DefaultBreak());
            }
        }
    }
}
