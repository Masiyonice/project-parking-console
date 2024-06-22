using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp1
{
    internal class Car : Vehicle
    {
        
        public Car()
        {
        }

        public Car(string platNumber, string color) : base(platNumber, color)
        {
        }

    }
}
