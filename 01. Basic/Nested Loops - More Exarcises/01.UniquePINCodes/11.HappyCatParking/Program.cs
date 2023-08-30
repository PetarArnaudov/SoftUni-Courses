using System;

namespace _11.HappyCatParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double parkingPriceForHour = 0.0;
            double finalPrice = 0.0;
            double priceForDay = 0.0;

            for (int i = 1; i <= days; i++)
            {
                
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        parkingPriceForHour = 2.5;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        parkingPriceForHour = 1.25;
                    }
                    else
                    {
                        parkingPriceForHour = 1.0;
                    }

                    priceForDay += parkingPriceForHour;

                }
                finalPrice += priceForDay;
                
                Console.WriteLine($"Day: {i} - {priceForDay:f2} leva");
                priceForDay = 0;

            }

            Console.WriteLine($"Total: {finalPrice:f2} leva");
        }
    }
}
