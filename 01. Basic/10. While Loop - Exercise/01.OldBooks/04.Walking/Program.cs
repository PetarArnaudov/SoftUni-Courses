using System;
using System.Xml.Schema;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int treshold = 10000;

            string input = Console.ReadLine();
            int totalSteps = 0;
            bool goalIsReached = false;

            while (input != "Going home")
            {
                int steps = int.Parse(input);
                totalSteps += steps;
                
                if (totalSteps >= treshold)
                {
                    goalIsReached = true;
                    break;   
                }


                input = Console.ReadLine();
            }

            if (!goalIsReached)
            {
                int stepsGoingHome = int.Parse(Console.ReadLine());
                totalSteps += stepsGoingHome;
            }

            if (totalSteps >= treshold)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - treshold} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{treshold - totalSteps} more steps to reach goal.");
            }
        }
    }
}
