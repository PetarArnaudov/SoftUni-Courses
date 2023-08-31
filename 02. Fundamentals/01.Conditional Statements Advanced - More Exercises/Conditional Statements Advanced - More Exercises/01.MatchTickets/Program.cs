using System;
using System.Reflection.PortableExecutable;

namespace _01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            if (category == "VIP")
            {
                ticketPrice = 499.99;
            } else
            {
                ticketPrice = 249.99;
            }

            if (people <= 4)
            {
                budget *= 0.25;
            }
            else if (people <= 9)
            {
                budget *= 0.4;
            }
            else if (people <= 24)
            {
                budget *= 0.5;
            } 
            else if (people <= 49)
            {
                budget *= 0.6;
            } 
            else
            {
                budget *= 0.75;
            }

            if (budget >= ticketPrice * people)
            {
                Console.WriteLine($"Yes! You have {budget - ticketPrice * people:f2} leva left.");
            } else
            {
                Console.WriteLine($"Not enough money! You need {ticketPrice * people - budget:f2} leva.");
            }
        }
    }
}
