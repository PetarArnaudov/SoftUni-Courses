using System;

namespace _05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodNeeded = double.Parse(Console.ReadLine());
            double catFoodNeeded = double.Parse(Console.ReadLine());
            double turtleFoodNeeded = double.Parse(Console.ReadLine());

            double totalFoodNeeded = dogFoodNeeded * daysOff + catFoodNeeded * daysOff + (turtleFoodNeeded / 1000)* daysOff;

            if (totalFoodNeeded <= food)
            {
                double foodLeft = food - totalFoodNeeded;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            } else
            {
                double foodNeeded = totalFoodNeeded - food;
                Console.WriteLine($"{Math.Ceiling(foodNeeded)} more kilos of food are needed.");
            }
        }
    }
}
