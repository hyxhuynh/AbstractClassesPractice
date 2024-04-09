using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Vehicles
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public override int Year { get; set; }

        //Inherit non-abstract member, re-writing not needed
        //public string Make { get; set; }
        public override string Model { get; set; }

        public override void DisplayVehicleDetails()
        {
            Console.WriteLine($"{Make} {Model} {Year} has trunk: {HasTrunk}");
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"Driving {Make} {Model} {Year} car abstract-ly...");
        }

    }
}
