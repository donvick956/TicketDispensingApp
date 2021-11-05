using System;

namespace TicketDispensingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ticketType = new Ticket();
            ticketType.ticketNumber();
            
      
        }
    }
    class Ticket

    {
        public int year = 0;
        public double total = 0; 
        public double bossMoney;
        public string ticketType;
        public void ticketNumber()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Please Enter the ticket type either Daily or Monthly");
            string ticketType = Console.ReadLine();
            

        }
        public double Amount()
        {
            Console.WriteLine($"Amount accumulate is {total} for {year} years");
            Console.WriteLine($"You are to remit {bossMoney} to your Boss");
            return Amount();
        }
    }
}


    

