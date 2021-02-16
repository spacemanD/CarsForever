using CarsForever.Enums;
using CarsForever.Exceptions;
using CarsForever.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsForever.Classes
{
    public abstract class RaceCar : Vehicle, IPetrol
    {
        public decimal Tank { get; set; }

        public decimal Balance { get; set; }
        public override void Move()
        {
            Console.WriteLine($"");
        }
        public void FuelCapacity(FuelCapacityEnum operationCode)
        {
            switch (operationCode)
            {
                case FuelCapacityEnum.Empty:
                    {
                        if (Tank == 0)
                        {
                            throw new EmptyTankExeption();
                        }

                        break;
                    }
                case FuelCapacityEnum.SemiCharged:
                    {
                        if (Tank == 0 )
                        {
                            throw new EmptyTankExeption();
                        }
                        Console.WriteLine("You need to find petrol station");
                        break;
                    }
                case FuelCapacityEnum.Full:
                    {
                        
                        break;
                    }
            }
        }
    }
}
