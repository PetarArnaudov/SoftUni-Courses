using System;

namespace _01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double p1Water = p1 * h; // 300 * 100 / 1000
            double p2Water = p2 * h; 

            double totalWater = p1Water + p2Water;

            if (totalWater <= v)
            {
                Console.WriteLine($"The pool is {totalWater*100 / v:f2}% full. Pipe 1: {p1Water*100/totalWater:f2}%. Pipe 2: {p2Water*100/totalWater:f2}%.");
            } else
            {
                Console.WriteLine($"For {h} hours the pool overflows with {totalWater-v:f2} liters.");
            }
        }
    }
}
