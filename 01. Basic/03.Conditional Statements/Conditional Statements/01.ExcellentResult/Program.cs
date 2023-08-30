using System;

namespace _01.ExcellentResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            if (n >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
