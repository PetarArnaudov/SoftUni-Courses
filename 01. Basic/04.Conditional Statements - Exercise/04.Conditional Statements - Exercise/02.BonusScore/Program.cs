using System;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int originalPoints = int.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (originalPoints <= 100)
            {
                bonusPoints = 5;
            }
            else if (originalPoints <= 1000)
            {
                bonusPoints = 0.2 * originalPoints;
            } else
            {
                bonusPoints = 0.1 * originalPoints;
            }

            if (originalPoints % 2 == 0)
            {
                bonusPoints += 1;
            }
            if (originalPoints % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(originalPoints + bonusPoints);
        }
    }
}
