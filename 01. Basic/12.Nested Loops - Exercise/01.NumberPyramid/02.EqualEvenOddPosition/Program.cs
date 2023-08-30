using System;
using System.Diagnostics.CodeAnalysis;

namespace _02.EqualEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            
            

            for (int i = start; i <= end; i++)
            {
                int number = i;

                int evenSum = 0;
                int oddSum = 0;
                int position = 6;
                while (number != 0)
                {
                    int lastDigit = number % 10;
                    number /= 10;

                    if (position % 2 == 0)
                    {
                        evenSum += lastDigit;
                    }
                    else
                    {
                        oddSum += lastDigit;
                    }
                    position--;
                }

                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }

            
            
        }
    }
}
