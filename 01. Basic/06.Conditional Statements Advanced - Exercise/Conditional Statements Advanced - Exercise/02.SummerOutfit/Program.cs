using System;

namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string period = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (temperature >= 10 && temperature <= 18)
            {
                if (period == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (period == "Afternoon" || period == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temperature > 18 && temperature <=24)
            {
                if (period == "Morning" || period == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (period == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (temperature >= 25)
            {
                if (period == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (period == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (period == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
        }
    }
}
