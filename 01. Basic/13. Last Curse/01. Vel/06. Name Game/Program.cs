using System;
using System.Reflection;

namespace _06._Name_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int hearthstoneCounter = 0;
            int forniteCounter = 0;
            int overwatchCounter = 0;
            int othersCounter = 0;


            for (int i = 0; i < n; i++)
            {
                string nameOfGame = Console.ReadLine();

                if (nameOfGame == "Hearthstone")
                {
                    hearthstoneCounter++;
                }
                else if (nameOfGame == "Fornite")
                {
                    forniteCounter++;
                }
                else if (nameOfGame == "Overwatch")
                {
                    overwatchCounter++;
                }
                else
                {
                    othersCounter++;
                }
            }

            double hearthstonePercent = (double)hearthstoneCounter / n;
            double fornitePercent = (double)forniteCounter / n;
            double overwatchPercent = (double)overwatchCounter / n;
            double othersPercent = (double)othersCounter / n;

            Console.WriteLine($"Hearthstone - {hearthstonePercent*100:f2}%");
            Console.WriteLine($"Fornite - {fornitePercent*100:f2}%");
            Console.WriteLine($"Overwatch - {overwatchPercent*100:f2}%");
            Console.WriteLine($"Others - {othersPercent*100:f2}%");

           
        }
    }
}
