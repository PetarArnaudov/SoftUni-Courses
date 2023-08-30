using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();

            string destination = "";
            double totalPrice = 0;
            string location = "";

            // „summer” или “winter

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (seson == "summer")
                {
                    totalPrice = budget * 0.3;
                    location = "Camp";
                } else
                {
                    totalPrice = budget * 0.7;
                    location = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (seson == "summer")
                {
                    totalPrice = budget * 0.4;
                    location = "Camp";
                }
                else
                {
                    totalPrice = budget * 0.8;
                    location = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                totalPrice = budget * 0.9;
                location = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{location} - {totalPrice:f2}");
        }
    }
}
