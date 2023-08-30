using System;
using System.Globalization;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int totalCakePieces = width * lenght;
            bool noMoreCake = false;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int pieces = int.Parse(input);
                totalCakePieces -= pieces;
                if (totalCakePieces < 0)
                {
                    noMoreCake = true;
                    break;
                }
                

                input = Console.ReadLine();
            }
            
            if (!noMoreCake)
            {
                Console.WriteLine($"{totalCakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {totalCakePieces * -1} pieces more.");
            }
        }
    }
}
