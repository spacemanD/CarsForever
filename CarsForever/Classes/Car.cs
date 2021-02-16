using CarsForever.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsForever.Classes
{
    public abstract class Car : Vehicle, IMoveable
    {

        public Car(int age, int number)
        {
            this.Mileage = age;
            this.Number = number;
        }

    }
}
