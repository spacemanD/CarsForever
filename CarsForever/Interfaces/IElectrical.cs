using System;
using System.Collections.Generic;
using System.Text;

namespace CarsForever.Interfaces
{
    public interface IElectrical
    {
        public virtual void Charge()
        {
            Console.WriteLine("Car is charging");
        }

    }
}
