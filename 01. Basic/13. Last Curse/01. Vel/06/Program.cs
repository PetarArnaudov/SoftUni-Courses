using System;
using System.Security.Cryptography;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turnamentTime = int.Parse(Console.ReadLine());
            double allMoney = 0;
            int allWinCOunter = 0;
            int allLoseCOunter = 0;

            for (int i = 0; i < turnamentTime; i++)
            {
                int winCounter = 0;
                int loseCounter = 0;
                double money = 0;

                string nameOfGame = Console.ReadLine();

                while (nameOfGame != "Finish")
                {
                    string winOrLose = Console.ReadLine();

                    if (winOrLose == "win")
                    {
                        money += 20;
                        winCounter++;
                    }
                    else
                    {
                        loseCounter++;
                    }

                    nameOfGame = Console.ReadLine();
                }
                
                if ( winCounter > loseCounter )
                {
                    money *= 1.1;
                    allWinCOunter++;
                }
                else
                {
                    allLoseCOunter++;
                }

                allMoney += money;

             }
            bool isTurnamentWon = false;

            if (allWinCOunter > allLoseCOunter)
            {
                allMoney *= 1.2;
                isTurnamentWon = true;
            }

            if (isTurnamentWon)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {allMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {allMoney:f2}");
            }

        }
    }
}
