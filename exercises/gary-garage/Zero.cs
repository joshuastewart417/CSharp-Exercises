using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
    
        public void ChargeBattery()
        {
           CurrentChargePercentage = 100;
        }

        public int CurrentChargePercentage { get; set; } = 88;

        public override void Drive()
        {
            Console.WriteLine("The yellow Zero zooms into the horizon. BYAKUSHAAHHHH!!!");
        }
    }
}