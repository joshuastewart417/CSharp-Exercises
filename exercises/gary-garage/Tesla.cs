using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
           CurrentChargePercentage = 100;
        }

        public int CurrentChargePercentage { get; set; } = 33;
        public override void Drive()
        {
            Console.WriteLine("The Tesla's battery catches on fire! Oh the humanity!");
        }
    }
}