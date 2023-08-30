using System;
using System.Diagnostics;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = 0;
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardsCount = 0;
            int displaysCount = 0;

            for (int i = 2; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                }
                if ( i % 2 == 0 && i  % 3 == 0)
                {
                    keyboardsCount++;
                }
            }
            displaysCount = keyboardsCount / 2;

            expenses = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardPrice * keyboardsCount + displayPrice * displaysCount;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
