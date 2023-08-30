using System;

namespace _03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string seson = Console.ReadLine();  
            string holidayOrNot = Console.ReadLine();

            double finalPrice = 0;
            double chrysanthemumsPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;

            
            if (seson == "Spring" || seson == "Summer")
            {
                chrysanthemumsPrice = 2;
                rosesPrice = 4.1;
                tulipsPrice = 2.5;

                if (holidayOrNot == "Y")
                {
                    chrysanthemumsPrice *= 1.15;
                    rosesPrice *= 1.15;
                    tulipsPrice *= 1.15;
                }

                finalPrice = chrysanthemums * chrysanthemumsPrice + roses * rosesPrice + tulips * tulipsPrice;

                if (tulips > 7)
                {
                    finalPrice *= 0.95;
                }
            }
            else //Аutumn, Winter
            {
                chrysanthemumsPrice = 3.75;
                rosesPrice = 4.5;
                tulipsPrice = 4.15;

                if (holidayOrNot == "Y")
                {
                    chrysanthemumsPrice *= 1.15;
                    rosesPrice *= 1.15;
                    tulipsPrice *= 1.15;
                }

                finalPrice = chrysanthemums * chrysanthemumsPrice + roses * rosesPrice + tulips * tulipsPrice;

                if (roses >= 10 && seson == "Winter")
                {
                    finalPrice *= 0.9;
                }
            }

            if (roses + tulips + chrysanthemums > 20)
            {
                finalPrice *= 0.8;
            }

            finalPrice += 2;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
