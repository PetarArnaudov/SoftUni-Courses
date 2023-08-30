using System;
using System.Net.NetworkInformation;

namespace _05.GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turns = int.Parse(Console.ReadLine());
            double result = 0.0;

            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0;

            for (int i = 0; i < turns; i++) 
            {
                int points = int.Parse(Console.ReadLine());

                if (points < 0) { p6++; result /= 2; }
                else if (points <= 9) { p1++; result += 0.2 * points; }
                else if (points <= 19) { p2++; result += 0.3 * points; }
                else if (points <= 29) { p3++; result += 0.4 * points; }
                else if (points <= 39) { p4++; result += 50; }
                else if (points <= 50) { p5++; result += 100; }
                else { p6++; result /= 2; }
            }


            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(p1 * 100.0) / turns:f2}%");
            Console.WriteLine($"From 10 to 19: {(p2 * 100.0) / turns:f2}%");
            Console.WriteLine($"From 20 to 29: {(p3 * 100.0) / turns:f2}%");
            Console.WriteLine($"From 30 to 39: {(p4 * 100.0) / turns:f2}%");
            Console.WriteLine($"From 40 to 50: {(p5 * 100.0) / turns:f2}%");
            Console.WriteLine($"Invalid numbers: {(p6 * 100.0) / turns:f2}%");

        }
    }
}
