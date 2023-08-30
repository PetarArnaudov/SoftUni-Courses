using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int eposodeTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = 0.125 * breakTime;

            double restTime = 0.25 * breakTime;

            double requiredTime = eposodeTime + lunchTime + restTime;

            if (breakTime >= requiredTime)
            {
                Console.WriteLine($"You have enough time to watch {name} " +
                $"and left with {Math.Ceiling(breakTime-requiredTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, " +
                $"you need {Math.Ceiling(requiredTime-breakTime)} more minutes.");
            }

            
            
        }
    }
}
