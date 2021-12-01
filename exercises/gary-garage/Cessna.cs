using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public int CurrentTankPercentage { get; set; } = 73;

        public override void Drive()
        {
            Console.WriteLine("The White Cessna flies overhead! Myeooooowwwwwww!");
        }
    }
}