using System;

namespace _10._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oneLeva = int.Parse(Console.ReadLine());
            int twoLeva = int.Parse(Console.ReadLine());
            int fiveLeva = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= oneLeva; i++)
            {
                for (int j = 0; j <= twoLeva; j++)
                {
                    for (int k = 0; k <= fiveLeva; k++)
                    {
                        if (k * 5 + j * 2 + i * 1 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }

        }
    }
}
