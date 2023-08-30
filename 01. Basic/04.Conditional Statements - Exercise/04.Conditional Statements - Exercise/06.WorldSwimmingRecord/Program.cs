using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double neededTime = distance * timePerMeter;
            double additionalTime = Math.Floor(distance / 15) * 12.5;


            double finalTime = neededTime + additionalTime;

            

            if (finalTime < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            } 
            else
            {
                Console.WriteLine($"No, he failed! He was {finalTime-record:f2} seconds slower.");
            }
        }
    }
}
