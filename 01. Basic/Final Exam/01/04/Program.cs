using System;

namespace _04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalRakia = 0;
            double totalDegrees = 0;

            for (int i = 0; i < n; i++)
            {
                double rakiaCount = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());

                totalRakia += rakiaCount;
                totalDegrees += rakiaCount * degrees;

            }

            Console.WriteLine($"Liter: {totalRakia:f2}");
            Console.WriteLine($"Degrees: {totalDegrees / totalRakia:f2}");

            if (totalDegrees / totalRakia < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (totalDegrees / totalRakia <= 42)
            {
                Console.WriteLine("Super!");
            }
            else 
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
