using CarsForever.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsForever.Classes
{
    public abstract class Track: Vehicle, IPetrol
    {
        public override void AllWheelDrive()    
        {
            Console.WriteLine("Car with number {0} had full-wheel drive", this.Number);
        }

        public void Allwheeldrive(string phrase)
        {
            Console.WriteLine("Car with number {0} had {1}", this.Number, phrase);
        }
    }
}
