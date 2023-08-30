using System;

namespace _02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            int normForPlay = 30000;
            int workingDays = 365;

            int workingDaysPlayTime = (workingDays - restDays) * 63;
            int restDaysPlayTime = restDays * 127;
            int totalPlayTime = workingDaysPlayTime + restDaysPlayTime;

            int h = (normForPlay-totalPlayTime) / 60;
            int m = (normForPlay - totalPlayTime) - h * 60;

            
            if (totalPlayTime <= normForPlay)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{h} hours and {m} minutes less for play");
            } else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(h)} hours and {Math.Abs(m)} minutes more for play");
            }
           
        }
    }
}
