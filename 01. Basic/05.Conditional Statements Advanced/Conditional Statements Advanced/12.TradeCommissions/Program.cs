using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double comision = 0;

            switch (city)
            {
                case "Sofia":
                    if (sells < 0)
                    {
                        Console.WriteLine("error");
                    }
                    if (sells >= 0 && sells <= 500)
                    {
                        comision = 5;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comision = 7;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comision = 8;
                    }
                    else if (sells > 10000)
                    {
                        comision = 12;
                    }
                    break;
                case "Varna":
                    if (sells < 0)
                    {
                        Console.WriteLine("error");
                    }
                    if (sells >= 0 && sells <= 500)
                    {
                        comision = 4.5;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comision = 7.5;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comision = 10;
                    }
                    else if (sells > 10000)
                    {
                        comision = 13;
                    }
                    break;
                case "Plovdiv":
                    if (sells < 0)
                    {
                        Console.WriteLine("error");
                    }
                    if (sells >= 0 && sells <= 500)
                    {
                        comision = 5.5;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comision = 8;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comision = 12;
                    }
                    else if (sells > 10000)
                    {
                        comision = 14.5;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            if (comision > 0)
            {
                double result = sells * comision / 100;
                Console.WriteLine($"{result:F2}");
            }
        }
    }
}