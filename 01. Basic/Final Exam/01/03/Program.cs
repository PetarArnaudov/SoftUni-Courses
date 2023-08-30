using System;

namespace _03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double roomPrice = 0;
            double finalPrice = 0;

            days -= 1;

            if (roomType == "room for one person")
            {
                roomPrice = 18;
                finalPrice = roomPrice * days;
            }
            else if (roomType == "apartment")
            {
                roomPrice = 25;
                finalPrice = roomPrice * days;

                if (days < 10)
                {
                    finalPrice *= 0.7;
                }
                else if (days <= 15)
                {
                    finalPrice *= 0.65;
                }
                else
                {
                    finalPrice *= 0.5;
                }
            }
            else
            {
                roomPrice = 35;
                finalPrice = roomPrice * days;

                if (days < 10)
                {
                    finalPrice *= 0.9;
                }
                else if (days <= 15)
                {
                    finalPrice *= 0.85;
                }
                else
                {
                    finalPrice *= 0.8;
                }
            }

            if (rating == "positive")
            {
                finalPrice *= 1.25;
            }
            else
            {
                finalPrice *= 0.9;
            }

            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
