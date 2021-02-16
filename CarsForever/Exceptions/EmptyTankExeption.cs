using CarsForever.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsForever.Exceptions
{
    public class EmptyTankExeption : Exception
    {

        public EmptyTankExeption() : base(ErrorMessages.EmptyTankExeption)
        {
        }

        public EmptyTankExeption(string message) : base(message)
        {
        }

    }
}
