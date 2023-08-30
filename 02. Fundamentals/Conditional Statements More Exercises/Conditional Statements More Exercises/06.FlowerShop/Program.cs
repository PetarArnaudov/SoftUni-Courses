using System;

namespace _06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double profit = (m * 3.25 + z * 4 + r * 3.5 + c * 8) * 0.95;

            if (profit >= giftPrice)
            {
                double moneyLeft = profit - giftPrice;
                Console.WriteLine($"She is left with {Math.Floor(moneyLeft)} leva.");
            } else
            {
                double moneyNeeded = giftPrice - profit;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyNeeded)} leva.");
            }
        }
    }
}
