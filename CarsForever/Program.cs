using System;

namespace CarsForever
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main entry in program {StartManager.ProgramName}");
            StartManager.Start();
        }
    }
}
