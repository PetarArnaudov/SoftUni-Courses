using System;

namespace _03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // •	До 3 тона – микробус(200 лева на тон)
           //•	От 4 до 11 тона – камион(175 лева на тон)
           // •	12 и повече тона – влак(120 лева на тон)

            int cargo = int.Parse(Console.ReadLine());
            int totalCargo = 0;
            double totalCargoPrice = 0;

            int car = 0, truck = 0, train = 0;
            
            for (int i = 0; i < cargo; i++)
            {
                int currentCargo = int.Parse(Console.ReadLine());
                totalCargo += currentCargo;
                if (currentCargo <= 3)
                {
                    totalCargoPrice += currentCargo * 200;
                    car += currentCargo;
                }
                else if (currentCargo <= 11)
                {
                    totalCargoPrice += currentCargo * 175;
                    truck += currentCargo;
                }
                else
                {
                    totalCargoPrice += currentCargo * 120;
                    train += currentCargo;
                }
            }

            Console.WriteLine($"{totalCargoPrice / totalCargo:f2}");
            Console.WriteLine($"{(car * 100.0) / totalCargo:f2}%");
            Console.WriteLine($"{(truck * 100.0) / totalCargo:f2}%");
            Console.WriteLine($"{(train * 100.0) / totalCargo:f2}%");
        }
    }
}
