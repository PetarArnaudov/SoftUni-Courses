using System;

namespace _02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            double juniorsTax = 0;
            double seniorsTax = 0;
            double result = 0;
            
            if (trace == "trail")
            {
                juniorsTax = 5.5;
                seniorsTax = 7;
            }
            else if (trace == "cross-country")
            {
                juniorsTax = 8;
                seniorsTax = 9.5;

                if (juniors + seniors >= 50)
                {
                    juniorsTax *= 0.75;
                    seniorsTax *= 0.75;
                }
            }
            else if (trace == "downhill")
            {
                juniorsTax = 12.25;
                seniorsTax = 13.75;
            } 
            else
            {
                // "road"
                juniorsTax = 20;
                seniorsTax = 21.5;
            }

            result = juniors * juniorsTax + seniors * seniorsTax;
            result *= 0.95;

            Console.WriteLine($"{result:f2}");
        }
    }
}
