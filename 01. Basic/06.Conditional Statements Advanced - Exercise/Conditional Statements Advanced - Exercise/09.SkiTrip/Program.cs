using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string satisfaction = Console.ReadLine();
            int nights = days - 1;

            double price = 0;

            if (room == "room for one person")
            {
                price = nights * 18;
            }
            else if (room == "apartment")
            {
                price = nights * 25;

                if (nights < 10)
                {
                    price *= 0.7;
                }
                else if (nights <= 15)
                {
                    price *= 0.65;
                }
                else
                {
                    price *= 0.5;
                }
            }
            else
            {
                price = nights * 35;

                if (nights < 10)
                {
                    price *= 0.9;
                }
                else if (nights <= 15)
                {
                    price *= 0.85;
                }
                else
                {
                    price *= 0.8;
                }
            }

            if (satisfaction == "positive")
            {
                price *= 1.25;
            } else
            {
                price *= 0.9;
            }

            Console.WriteLine($"{price:f2}");

        }
    }
}
