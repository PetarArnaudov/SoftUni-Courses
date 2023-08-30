using System;
using System.Diagnostics.Tracing;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;

            for (int i = 1; i <= int.MaxValue; i++)
            {
                if (counter >= n)
                {
                    break;
                }
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    counter++;
                    sum += i;
                    
                }
                
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
