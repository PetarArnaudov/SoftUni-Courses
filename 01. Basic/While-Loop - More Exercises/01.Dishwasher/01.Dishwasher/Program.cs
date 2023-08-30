using System;
using System.Diagnostics.Tracing;

namespace _01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            int detergent = bottles * 750;
            int counter = 1;
            string input = Console.ReadLine();
            bool isEnough = false;

            int dishesCounter = 0;
            int potsCounter = 0;

            while (input != "End")
            {
                int dishes = int.Parse(input);

                if (counter % 3 == 0)
                {
                    detergent -= dishes * 15;
                    potsCounter += dishes;
                }
                else
                {
                    detergent -= dishes * 5;
                    dishesCounter += dishes;
                }

                if (detergent < 0)
                {
                    isEnough = true;
                    break;
                }

                counter++;
                input = Console.ReadLine();
            }

            if (!isEnough)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishesCounter} dishes and {potsCounter} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {-1 * detergent} ml. more necessary!");
            }
        }

    }
}
