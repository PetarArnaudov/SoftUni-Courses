using System;
using System.Transactions;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double chickenPrice = chicken * 10.35;
            double fishPrice = fish * 12.40;
            double veganPrice = vegan * 8.15;
            double dessertPrice = (chickenPrice + fishPrice + veganPrice) * 0.2;
            double deliveryPrice = 2.50;

            Console.WriteLine(chickenPrice + fishPrice + veganPrice + dessertPrice + deliveryPrice);
        }
    }
}
