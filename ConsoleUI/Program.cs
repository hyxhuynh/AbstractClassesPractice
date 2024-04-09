using ConsoleUI.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

            // List of Vehicle 
            List<Vehicle> vehicles = new List<Vehicle>();

            // First vehicle
            Car car1 = new Car()
            {
                Year = 2024,
                Make = "Tesla",
                Model = "Cybertruck",
                HasTrunk = true,
            };

            vehicles.Add(car1);

            // Second vehicle 
            Motorcycle motorcycle1 = new Motorcycle()
            {
                Year = 2024,
                Make = "Yamaha",
                Model = "Supersport",
                HasSideCart = false,
            };

            vehicles.Add(motorcycle1);

            // Third vehicle
            Vehicle vehicle1 = new Car()
            {
                Year = 2025,
                Make = "Lamborghini",
                Model = "Huracan",
                HasTrunk = true
            };

            vehicles.Add(vehicle1);

            // Fourth vehicle
            Vehicle vehicle2 = new Motorcycle()
            {
                Year = 1998, 
                //Make property was made default in Vehicle class
                Model = "Dream",
                HasSideCart = false
            };

            vehicles.Add(vehicle2);

            // Display properties
            foreach (var v in vehicles)
            {
                Console.WriteLine(v.Make);
                Console.WriteLine(v.Model);
                Console.WriteLine(v.Year);
                v.DisplayVehicleDetails();
                Console.WriteLine("------------------------");
            }

            // Display drive methods for one car and one motorcycle
            car1.DriveAbstract();
            car1.DriveVirtual();
            Console.WriteLine("------------------------");
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();
            Console.WriteLine("------------------------");
            #endregion            
            Console.ReadLine();
        }
    }
}
