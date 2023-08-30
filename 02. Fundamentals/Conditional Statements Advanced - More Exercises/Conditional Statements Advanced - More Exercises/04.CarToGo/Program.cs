using System;

namespace _04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();
            string carClass = "";
            string carType = "";
            double carPrice = 0;

            if (budget <= 100)
            {
                carClass = "Economy class";

                if (seson == "Summer")
                {
                    carType = "Cabrio";
                    carPrice = budget * 0.35;
                } 
                else
                {
                    carType = "Jeep";
                    carPrice = budget * 0.65;
                }

            }
            else if (budget <= 500)
            {
                carClass = "Compact class";

                if (seson == "Summer")
                {
                    carType = "Cabrio";
                    carPrice = budget * 0.45;
                }
                else
                {
                    carType = "Jeep";
                    carPrice = budget * 0.8;
                }

            }
            else 
            {
                carClass = "Luxury class";
                carType = "Jeep";
                carPrice = budget * 0.9;
            }

            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {carPrice:f2}");
        }
    }
}
