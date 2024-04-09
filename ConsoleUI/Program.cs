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
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            // Vehicle 1
            Car car1 = new Car()
            {
                Year = 2024,
                Make = "Tesla",
                Model = "Cybertruck",
                HasTrunk = true,
            };

            vehicles.Add(car1);

            // Vehicle 2
            Motorcycle motorcycle1 = new Motorcycle()
            {
                Year = 2024,
                Make = "Yamaha",
                Model = "Supersport",
                HasSideCart = false,
            };

            vehicles.Add(motorcycle1);

            // Vehicle 3
            Vehicle car2 = new Car()
            {
                Year = 2025,
                Make = "Lamborghini",
                Model = "Huracan",
                HasTrunk = true
            };

            vehicles.Add(car2);

            // Vehicle 4
            Vehicle motorcycle2 = new Motorcycle()
            {
                Year = 2024,
                Make = "Suzuki",
                Model = "GSX-8R",
                HasSideCart = false
            };

            vehicles.Add(motorcycle2);

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            foreach (var v in vehicles)
            {
                Console.WriteLine(v.Make);
                Console.WriteLine(v.Model);
                Console.WriteLine(v.Year);
                v.DisplayVehicleDetails();
                Console.WriteLine("------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle
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
