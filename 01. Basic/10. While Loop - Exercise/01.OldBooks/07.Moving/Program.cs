using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int totalSpace = width * lenght * hight;
            string input = Console.ReadLine();
            bool noMoreSpace = false;

            while (input != "Done")
            {
                int lugage = int.Parse(input);
                totalSpace -= lugage;
                if (totalSpace < 0)
                {
                    noMoreSpace = true;
                    break;
                }

                input = Console.ReadLine();
            }


            if (!noMoreSpace)
            {
                Console.WriteLine($"{totalSpace} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {-1 * totalSpace} Cubic meters more.");
            }
        }
    }
}
