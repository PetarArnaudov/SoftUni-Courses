using System;

namespace _10.WeatherForecastPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишете програма, която при въведени градуси(реално число) принтира какво е времето, като имате предвид следната таблица:
                Градуси Време
                26.00 - 35.00   Hot
                20.1 - 25.9 Warm
                15.00 - 20.00   Mild
                12.00 - 14.9    Cool
                5.00 - 11.9 Cold
                Ако се въведат градуси, различни от посочените в таблицата, да се отпечата "unknown". */

            double input = double.Parse(Console.ReadLine());

            if (input >= 5 && input <= 35)
            {
                if (input >= 26)
                {
                    Console.WriteLine("Hot");
                }
                else if (input >= 20.1)
                {
                    Console.WriteLine("Warm");
                }
                else  if (input >= 15)
                {
                    Console.WriteLine("Mild");
                } else if (input >= 12)
                {
                    Console.WriteLine("Cool");
                }
                else if (input >= 5)
                {
                    Console.WriteLine("Cold");
                }
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
