using System;

namespace _01._Vel_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cakePrice = 3.20;
            double eggsPrice = 4.35;
            double cookies = 5.40;
            double egssPaint = 0.15;

            int cakeCount = int.Parse(Console.ReadLine());
            int eggsCount = int.Parse(Console.ReadLine());
            int cociesKg = int.Parse(Console.ReadLine());

            double finalCackePrice = cakePrice * cakeCount;
            double finalEgsPrice = eggsPrice * eggsCount;
            double finalCookiesPrice = cookies * cociesKg;
            double finalEggsPaintingPrice = egssPaint * eggsCount * 12;

            Console.WriteLine($"{ finalEggsPaintingPrice + finalEgsPrice + finalCookiesPrice + finalCackePrice:f2}");
        }
    }
}
