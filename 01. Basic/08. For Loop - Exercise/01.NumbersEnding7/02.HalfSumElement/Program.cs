using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                sum += currNum;

                if (currNum > max)
                {
                    max = currNum;
                }
            }

            int diff = Math.Abs(sum - max * 2);

            if (diff == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
