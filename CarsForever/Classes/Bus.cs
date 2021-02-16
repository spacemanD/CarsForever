using CarsForever.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsForever.Classes
{
    public abstract class Bus : Vehicle, IMoveable
    {
        public virtual void MakeStop()
        {
            Console.WriteLine($"PassengerCars with number {0} made a stop ", this.Number);
        }
        public virtual void PayForShipping()
        {
            Console.WriteLine($"PassengerCars's ticket with number {0} made a stop ", this.Number);
        }
        public override void AllWheelDrive()
        {
            Console.WriteLine($"Car has only two-wheel drive with number {0}  ", this.Number);
        }
    }
}
