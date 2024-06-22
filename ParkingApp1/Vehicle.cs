using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp1
{
    internal abstract class Vehicle
    {
        private string _plateNumber;
        private string _color;
        private DateTime _checkin;
        private DateTime _checkOut;
        
        public string PlatNumber {  get { return _plateNumber; } set { _plateNumber = value; } }
        public string Color { get { return _color; } set { _color = value; } } 
        public Vehicle() { }
        public Vehicle(string platNumber, string color) { 
            _color = color;
            _plateNumber = platNumber;
        }

        public DateTime Checkin { get { return _checkin; } set { _checkin = value; } }
        public DateTime Checkout { get { return _checkOut; } set { _checkOut = value; } }

        public override string? ToString()
        {
            return $"{_plateNumber } \t {_color}";
        }
    }
}
