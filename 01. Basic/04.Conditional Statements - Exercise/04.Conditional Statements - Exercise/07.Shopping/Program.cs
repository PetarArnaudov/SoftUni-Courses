using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetPeter = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videoCardsPrice = videoCards * 250;
            double processorsPrice = 0.35 * videoCardsPrice * processors;
            double ramPrice = 0.10 * videoCardsPrice * ram;
            
            double finalPrice = videoCardsPrice + processorsPrice + ramPrice;

            if (videoCards > processors)
            {
                finalPrice *= 0.85;
            }

            if (budgetPeter >= finalPrice) 
            {
                Console.WriteLine($"You have {budgetPeter - finalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalPrice - budgetPeter:f2} leva more!");
            }
        }
    }
}
