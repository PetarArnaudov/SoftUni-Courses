using System;

namespace _09_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNegative = false;
            double number = 0;

            while (!isNegative)
            {
                number = double.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    Console.WriteLine($"Result: {number * 2:f2}");
                } else
                {
                    Console.WriteLine("Negative number!");
                    isNegative = true;
                }
            }
        }
    }
}
