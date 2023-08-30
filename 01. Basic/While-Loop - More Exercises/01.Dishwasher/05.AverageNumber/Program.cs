using System;

namespace _05.AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            int i = 1;
            while (i <= n)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                i++;
            }

            Console.WriteLine($"{1.0 * sum / n:f2}");
        }
    }
}
