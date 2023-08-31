using System;

namespace _06.Truck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seson = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());

            double profit = 0;

            if (distance <= 5000)
            {
                if (seson == "Spring" || seson == "Autumn")
                {
                    profit = 0.75 * distance;
                } 
                else if ( seson == "Summer")
                {
                    profit = 0.9 * distance;
                }
                else // Winter
                {
                    profit = 1.05 * distance;
                }
            }
            else if (distance <= 10000)
            {
                if (seson == "Spring" || seson == "Autumn")
                {
                    profit = 0.95 * distance;
                }
                else if (seson == "Summer")
                {
                    profit = 1.10 * distance;
                }
                else // Winter
                {
                    profit = 1.25 * distance;
                }
            }
            else if (distance <= 20000)
            {
                profit = 1.45 * distance;
            }

            profit *= 4;
            profit *= 0.9;
            Console.WriteLine($"{profit:f2}");

        }
    }
}
