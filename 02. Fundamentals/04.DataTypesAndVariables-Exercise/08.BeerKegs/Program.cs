using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());
            string biggestKegName = "";
            double bigestVolume = 0;

            for (int i = 0; i < kegsCount; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (bigestVolume < volume)
                {
                    biggestKegName = model;
                    bigestVolume = volume;
                }
                
            }

            Console.WriteLine(biggestKegName);

        }
    }
}
