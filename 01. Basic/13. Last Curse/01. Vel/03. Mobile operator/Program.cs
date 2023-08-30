using System;
using System.Runtime.Serialization;

namespace _03._Mobile_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*      срок / тип Small Middle Large ExtraLarge
                1 година(one) 9.98 лв. 18.99 лв. 25.98 лв. 35.99 лв.
                2 години(two) 8.58 лв. 17.09 лв. 23.59 лв. 31.79 лв. 
             */

            string timeForContract = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string withMobileOperator = Console.ReadLine();
            int monthsForCharge = int.Parse(Console.ReadLine());

            double priceForMonth = 0;
            if (typeOfContract == "Small")
            {
                if (timeForContract == "one")
                {
                    priceForMonth = 9.98;
                }
                else
                {
                    priceForMonth = 8.58;
                }
            }
            else if (typeOfContract == "Middle")
            {
                if (timeForContract == "one")
                {
                    priceForMonth = 18.99;
                }
                else
                {
                    priceForMonth = 17.09;
                }
            }
            else if (typeOfContract == "Large")
            {
                if (timeForContract == "one")
                {
                    priceForMonth = 25.98;
                }
                else
                {
                    priceForMonth = 23.59;
                }
            }
            else if (typeOfContract == "ExtraLarge")
            {
                if (timeForContract == "one")
                {
                    priceForMonth = 35.99;
                }
                else
                {
                    priceForMonth = 31.79;
                }
            }

            if (withMobileOperator == "yes")
            {
                if (priceForMonth <= 10)
                {
                    priceForMonth += 5.50;
                }
                else if (priceForMonth <= 30)
                {
                    priceForMonth += 4.35;
                }
                else if (priceForMonth > 30)
                {
                    priceForMonth += 3.85;
                }
            }

            double finalPrice = priceForMonth * monthsForCharge;

            if (timeForContract == "two")
            {
                finalPrice *= 0.9625;
            }

            Console.WriteLine($"{finalPrice:f2} lv.");
        }
    }
}
