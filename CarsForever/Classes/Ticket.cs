using System;
using System.Collections.Generic;
using System.Text;

namespace CarsForever.Classes
{
    public abstract class Ticket
    {
        public int Cost { get; set; }

        public int Id { get; set; }

        public string Type { get; set; }

        public Ticket(int cost, int id)
        {
            this.Cost = cost;
            this.Id = id;
        }

        public virtual void Fare()
        {
            Console.WriteLine("You must buy a ticket");
        }
    }
}
