using System;

namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();

            string location = "";
            string place = "";
            double price = 0;

            if (budget <= 1000)
            {
                place = "Camp";

                if (seson == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }

            }
            else if (budget <= 3000)
            {
                place = "Hut";
                if (seson == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }
            }
            else
            {
                place = "Hotel";

                if (seson == "Summer")
                {
                    location = "Alaska"; 
                }
                else
                {
                    location = "Morocco";
                }
                price = budget * 0.90;
            }


            Console.WriteLine($"{location} - {place} - {price:f2}");
        }
    }
}
