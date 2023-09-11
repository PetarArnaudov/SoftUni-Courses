using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            short capacity = 255;
            int liters = 0;

            for (int i = 0; i < lines; i++)
            {
                int quantities = int.Parse(Console.ReadLine());

                if (liters + quantities > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    liters += quantities;
                }
            }

            Console.WriteLine(liters);
        }
    }
}
