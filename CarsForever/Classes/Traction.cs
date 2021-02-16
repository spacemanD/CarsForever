using CarsForever.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsForever.Classes
{
    public  class Traction : Vehicle, IElectrical 
    {
        public Traction(int age, int number)
        {
            this.Mileage = age;
            this.Number = number;
        }

        public override void Move()
        {
            Console.WriteLine($"Traction goes only along the route with number {this.Number} ");
        }
        public override void CostTicket()
        {
            Console.WriteLine($"Traction was paid by the government with number {this.Number} ");
        }
        public override void AllWheelDrive()
        {
            Console.WriteLine("Traction goes only by two-wheel drive with number {0} ", this.Number);

        }
        
    }
    
}
