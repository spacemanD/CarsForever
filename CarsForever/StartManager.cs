using CarsForever.Classes;
using CarsForever.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsForever
{
    public static class StartManager
    {
        public static string ProgramName = "Cars";

        
        public static void Start()
        {
            Traction bmw = new Traction (1233,2344);
            try
            {

            }
            catch (IndexOutOfRangeException ex)
            {

            }
            catch (Exception ex)
            {
                if (ex is EmptyTankExeption)
                {

                }
                else
                {

                }
            }
            finally
            {
                Console.WriteLine("Program is complited");
            }

        }
    }
}
