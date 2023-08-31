using System;

namespace _03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double wineHarvest = 0.4 * x;
            double wineMaterial = wineHarvest * y;
            double wine = wineMaterial / 2.5;

            
            if (wine >= z)
            {
                double wineLeft = wine - z;
                double wineForWorkers = wineLeft / workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");

                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineForWorkers)} liters per person.");
            }
            else
            {
                double neededWine = z - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine)} liters wine needed.");
            }

        }
    }
}
