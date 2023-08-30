using System;
using System.Collections.Generic;

namespace _02.FootballResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstResult = Console.ReadLine();
            string secondResult = Console.ReadLine();
            string thirdResult = Console.ReadLine();

            int wins = 0;
            int losts = 0;
            int draws = 0;

            int homeResult = int.Parse(firstResult[0].ToString());
            int guestResult = int.Parse(firstResult[2].ToString());

            if (homeResult > guestResult)
            {
                wins++;
            }
            else if (homeResult < guestResult)
            {
                losts++;
            }
            else
            {
                draws++;
            }

            int homeResult2 = int.Parse(secondResult[0].ToString());
            int guestResult2 = int.Parse(secondResult[2].ToString());

            if (homeResult2 > guestResult2)
            {
                wins++;
            }
            else if (homeResult2 < guestResult2)
            {
                losts++;
            }
            else
            {
                draws++;
            }

            int homeResult3 = int.Parse(thirdResult[0].ToString());
            int guestResult3 = int.Parse(thirdResult[2].ToString());

            if (homeResult3 > guestResult3)
            {
                wins++;
            }
            else if (homeResult3 < guestResult3)
            {
                losts++;
            }
            else
            {
                draws++;
            }

            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {losts} games.");
            Console.WriteLine($"Drawn games: {draws}");
        }
    }
}
