using System;

namespace Garage
{
    public class Vehicle 
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vehicle go vrooom!");
        }

        public virtual void Turn(string direction) {
            Console.WriteLine($"The vehicle turn {direction} go skrrrt");
        }

        public virtual void Stop() {
            Console.WriteLine("hold on to yo butts this baby gonna stop!");
        }
    }
}