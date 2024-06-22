using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp1
{
    internal class ParkingArea
    {
        private const string _available = "available";
        private string _name;
        private Vehicle[] _vehicles;
        private int _parkingSize;

        public static List<ParkingArea> parkingAreas = new List<ParkingArea>();

        public ParkingArea(string name)
        {
            _name = name;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public Vehicle[] Vehicles { get { return _vehicles; } }
        public int ParkingSize { get { return _parkingSize; } }


        public void setParking(int parkingSize)
        {
            _parkingSize = parkingSize;
            _vehicles = new Vehicle[_parkingSize];
            for (int i = 0; i < _parkingSize; i++)
            {
                _vehicles[i] = new Car(_available, _available);
            }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            int tempt = -1;
            if (_parkingSize > 0 && _parkingSize <= _vehicles.Length)
            {
                for (int i = 0; i < _vehicles.Length; i++) {
                    if (_vehicles[i].PlatNumber.Equals(_available)) {
                        Console.WriteLine($"Slot is available at {i+1}");
                        if (tempt == -1)
                        {
                            tempt = i;
                        } 
                    }
                    
                }
                _vehicles[tempt] = vehicle;
                _vehicles[tempt].Checkin = DateTime.Now;
                Console.WriteLine(_vehicles[tempt].ToString());
                Console.WriteLine($"fill at parking number {tempt + 1}");
                _parkingSize--;
            }
            else
            {
                Console.WriteLine("Full Parking");
            }
        }

        public int RemoveVehicle(String name)
        {
            for (int i = 0; i < _vehicles.Length; i++) {
                if (_vehicles[i].PlatNumber.Equals(name)) {
                    _vehicles[i].Checkout = DateTime.Now;
                    if (_vehicles[i] is Car) {
                        Console.WriteLine("==Car==");
                        Console.WriteLine($"get out {_vehicles[i].ToString()}");
                        _vehicles[i] = new Car(_available, _available);
                        _parkingSize++;
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("===Motorcycle===");
                        Console.WriteLine($"get out {_vehicles[i].ToString()}");
                        _vehicles[i] = new Motorcycle(_available, _available);
                        _parkingSize++;
                        return 2;
                    }
                }
            }
            return 0;
        }
        public void ListAll()
        {
            for(int i =0; i < _vehicles.Length; i++)
            {
                Console.Write($"slot {i + 1} \t");
                Console.WriteLine($"{_vehicles[i].ToString()}");
            }
        }
    }
}
