using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }
    
        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The yellow Zero zooms into the horizon. BYAKUSHAAHHHH!!!");
        }
    }
}