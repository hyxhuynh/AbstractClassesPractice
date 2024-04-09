using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Vehicles
{
    public abstract class Vehicle
    {
        public abstract int Year { get; set; }
        // Set default value to Make property
        public string Make { get; set; } = "Honda";
        public abstract string Model { get; set; }
        public abstract void DriveAbstract();
        public virtual void DriveVirtual() 
        {
            Console.WriteLine("Driving a random vehicle virtually...");
        }
        public abstract void DisplayVehicleDetails();
    }
}
