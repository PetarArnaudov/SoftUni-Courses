using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            if (flowerType == "Roses")
            {
                totalPrice = flowerCount * 5;

                if (flowerCount > 80)
                {
                    totalPrice *= 0.9;
                }
            }
            else if (flowerType == "Dahlias")
            {
                totalPrice = flowerCount * 3.8;

                if (flowerCount > 90)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                totalPrice = flowerCount * 2.8;

                if (flowerCount > 80)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                totalPrice = flowerCount * 3;

                if (flowerCount < 120)
                {
                    totalPrice *= 1.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                totalPrice = flowerCount * 2.5;

                if (flowerCount < 80)
                {
                    totalPrice *= 1.2;
                }
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with " +
                    $"{flowerCount} {flowerType} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
