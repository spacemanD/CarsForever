using CarsForever.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsForever.Classes
{
    public abstract class Vehicle :  IMoveable
    {
        public int Mileage { get; set; }

        public int Number { get; set; }

        public int Capacity { get; set; }

        public virtual void Registred()
        {
            Console.WriteLine($"Car with number {0}, have been registred", this.Number);
        }

        public abstract void Move();

        public abstract void CostTicket();

        public abstract void AllWheelDrive();       
    }
}

