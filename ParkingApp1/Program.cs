// See https://aka.ms/new-console-template for more information
using ParkingApp1;

Console.WriteLine("Hello, World!");
ParkingArea parkingArea1 = new ParkingArea("lantai 1");
parkingArea1.setParking(3);
Vehicle car1 = new Car();
car1.PlatNumber = "B-1234-XYZ";
car1.Color = "BLACK";   
Vehicle motorcycle = new Motorcycle();
motorcycle.PlatNumber = "F-1222-ADZ";
motorcycle.Color = "PINK";
parkingArea1.AddVehicle(car1);
parkingArea1.AddVehicle(motorcycle);
Console.WriteLine("Sisa parkir: " + parkingArea1.ParkingSize);
parkingArea1.ListAll();
int a = parkingArea1.RemoveVehicle("B-1234-XYZ");
parkingArea1.ListAll();
Console.WriteLine("Sisa parkir: " + parkingArea1.ParkingSize);