using System;

namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = int.Parse(Console.ReadLine());

            Console.WriteLine($"{meters / 1000:f2}");
        }
    }
}
