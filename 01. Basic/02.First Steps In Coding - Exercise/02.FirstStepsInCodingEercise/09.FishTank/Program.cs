using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());  

            int aquariumCapacity = lenght * width * height;
            double capacityInLiters = aquariumCapacity * 0.001;

            Console.WriteLine(capacityInLiters * (1 - procent * 0.01));
        }
    }
}
