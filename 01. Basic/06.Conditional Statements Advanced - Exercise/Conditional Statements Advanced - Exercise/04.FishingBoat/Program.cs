using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string seson = Console.ReadLine();
            int fishersCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            



            if (seson == "Spring")
            {
                totalPrice = 3000;

                if (fishersCount <= 6)
                {
                    totalPrice *= 0.9;
                }
                else if (fishersCount > 6 &&  fishersCount <= 11) 
                {
                    totalPrice *= 0.85;
                }
                else if (fishersCount >= 12)
                {
                    totalPrice *= 0.75;
                }
                if (fishersCount % 2 == 0)
                {
                    totalPrice *= 0.95;
                }
            }
            else if (seson == "Summer" || seson == "Autumn")
            {
                totalPrice = 4200;
                if (fishersCount <= 6)
                {
                    totalPrice *= 0.9;
                }
                else if (fishersCount > 6 && fishersCount <= 11)
                {
                    totalPrice *= 0.85;
                }
                else if (fishersCount >= 12)
                {
                    totalPrice *= 0.75;
                }
                if (fishersCount % 2 == 0 && seson == "Summer")
                {
                    totalPrice *= 0.95;
                }
            }
            else if (seson == "Winter")
            {
                totalPrice = 2600;

                if (fishersCount <= 6)
                {
                    totalPrice *= 0.9;
                }
                else if (fishersCount > 6 && fishersCount <= 11)
                {
                    totalPrice *= 0.85;
                }
                else if (fishersCount >= 12)
                {
                    totalPrice *= 0.75;
                }
                if (fishersCount % 2 == 0)
                {
                    totalPrice *= 0.95;
                }
            }


            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            } else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}
