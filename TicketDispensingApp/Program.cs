using System;
using System.Collections;

namespace TicketDispensingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var attendant = new Ticket();
            double money = attendant.TicketDispensing();

            for (int i = 0; i > -1; i++) 
            {
                Console.WriteLine("Sales Summary\n" + money);
                Console.WriteLine(" Boss Share\n" + (money) * 0.65 + "\n Your Share\n" + (money * 0.35));
                attendant.TicketICode();
                money = attendant.TicketDispensing();
            }

        }

    }
    public class Ticket
    {

        public int ticketTotal = 0;
        public double amountInTotal = 0;
        public Random round = new Random();
        ArrayList ticketId = new ArrayList();

        public double TicketDispensing()
        {
           
            Console.WriteLine("\n Welcome! \n Enter Ticket Type: 1 for Daily or  2 for Monthly");
            string typeOfTicket = Console.ReadLine();
            switch (typeOfTicket)
            {
                case "1": amountInTotal = amountInTotal + 2000; break;
                case "2": amountInTotal = amountInTotal + 1000; break;
                default: amountInTotal = amountInTotal + 0; break;
            }

            return amountInTotal;

        }
        public void TicketICode()
        {
            decimal newId = round.Next(10000);
            if (ticketTotal > 0)              
            {                                   
                foreach (decimal i in ticketId)
                {
                    {
                        while (newId == i)               
                        { newId = round.Next(10000); }       
                    }
                }
            }
            ticketId.Add(newId);
            ticketTotal += 1;
            Console.WriteLine("Ticket Sold is now \n" + ticketTotal + "  Ticket Code \n");
            for (int i = 0; i < ticketTotal; i++)
            {
                Console.WriteLine((i + 1) + "   " + ticketId[i]);
            }

        }






    }

}
