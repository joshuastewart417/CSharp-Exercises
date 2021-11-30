using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }
       

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The Black Ram zooms by you! AGHHHHHHH!!!!");
        }
    }
}