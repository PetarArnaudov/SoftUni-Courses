using System;

namespace _04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fruits = double.Parse(Console.ReadLine());
            double vegetables = double.Parse(Console.ReadLine());
            int kgFruits = Int32.Parse(Console.ReadLine());
            int kgVegetables = Int32.Parse(Console.ReadLine());

            double result = ((fruits * kgFruits) + (vegetables * kgVegetables)) / 1.94;
            Console.WriteLine("{0:F2}", result);
        }
    }
}
