using System;
using System.Diagnostics.Tracing;

namespace _09.SumTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            bool found = false;
            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        found = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
            

        }

    }
}
