using System;

namespace _07.FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuel = double.Parse(Console.ReadLine());

            // "Diesel", "Gasoline"  "Gas"
            if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
            {
                if (fuel >= 25)
                {
                    
                    Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                }
                else if (fuel < 25)
                {
                    fuelType.ToLower();
                    Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
