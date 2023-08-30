using System;

namespace _06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumberEnd = int.Parse(Console.ReadLine());
            int secondNumberEnd = int.Parse(Console.ReadLine());
            int thirdNumberEnd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstNumberEnd; i++)
            {
                for (int j = 1; j <= secondNumberEnd; j++)
                {
                    for(int k = 1; k <= thirdNumberEnd; k++)
                    {
                        if (i % 2 == 0 && k % 2 == 0 && (j == 2 || j == 3 || j == 5 || j == 7))
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
