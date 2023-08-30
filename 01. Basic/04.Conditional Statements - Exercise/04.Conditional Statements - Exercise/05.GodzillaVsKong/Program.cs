using System;

namespace _05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            double priceForClothing = double.Parse(Console.ReadLine());

            double totalPriceForDecor = budget * 0.1;
            double totalPriceForClothing = priceForClothing * peopleCount;

            if (peopleCount > 150)
            {
                totalPriceForClothing *= 0.9;
            }

            double totalPrice = totalPriceForDecor + totalPriceForClothing;

            if (budget >= totalPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice-budget:f2} leva more.");
            }
        }
    }
}
