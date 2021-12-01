using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
       
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public int CurrentTankPercentage { get; set; } = 12;
        public override void Drive()
        {
            Console.WriteLine("The Black Ram zooms by you! AGHHHHHHH!!!!");
        }
    }
}