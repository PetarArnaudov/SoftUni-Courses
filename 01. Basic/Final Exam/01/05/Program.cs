using System;

namespace _05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 8848 - 5364;
            int day = 1;
            bool reached = false;

            string sleepOrNot = Console.ReadLine();

            while (sleepOrNot != "END")
            {
                if (sleepOrNot == "Yes")
                {
                    day++;
                }
                if (day > 5)
                {
                    break;
                }
                int meters = int.Parse(Console.ReadLine());

                goal -= meters;

                if (goal <= 0)
                {
                    reached = true;
                    Console.WriteLine($"Goal reached for {day} days!");
                    break;
                }
                sleepOrNot = Console.ReadLine();
            }

            if (!reached)
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(8848 - goal);
            }
        }
    }
}
