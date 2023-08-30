using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int toysCount = puzzles + dolls + bears + minions + trucks;

            double profit = puzzles * 2.6 + dolls * 3 + bears * 4.1 +
                minions * 8.2 + trucks * 2;

            if (toysCount >= 50)
            {
                profit *= 0.75;
            }

            profit *= 0.9;

            if (profit >= tripPrice)
            {
                double rMoney = profit - tripPrice;
                Console.WriteLine($"Yes! {rMoney:f2} lv left.");
            }
            else
            {
                double rMoney = tripPrice - profit;
                Console.WriteLine($"Not enough money! {rMoney:f2} lv needed.");
            }
        }
    }
}
