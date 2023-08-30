using System;

namespace _04.Inches_toCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberInches = double.Parse(Console.ReadLine());
            double numberToCentimeters = numberInches * 2.54;

            Console.WriteLine(numberToCentimeters);
        }
    }
}
