using System;

namespace _01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pcuPrice = double.Parse(Console.ReadLine());
            double gpuPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine());

            double neededMoney = 0.0;

            pcuPrice *= 1.57;
            gpuPrice *= 1.57;
            ramPrice *= 1.57 * ramCount;

            pcuPrice *= 1 - discountPercentage;
            gpuPrice *= 1 - discountPercentage;

            neededMoney = pcuPrice + gpuPrice + ramPrice;



            Console.WriteLine($"Money needed - {neededMoney:f2} leva.");
        }
    }
}
