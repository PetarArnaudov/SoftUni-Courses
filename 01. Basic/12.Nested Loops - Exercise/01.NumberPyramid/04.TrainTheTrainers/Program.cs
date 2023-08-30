using System;
using System.Xml.Schema;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juriesCount = int.Parse(Console.ReadLine());
            int presentationCount = 0;
            string presentation = Console.ReadLine();
            double gredesSum = 0;

            while (presentation != "Finish")
            {
                double sum = 0;
                for (int i = 0; i < juriesCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    


                }

                double average = sum / juriesCount;
                Console.WriteLine($"{presentation} - {average:f2}.");
                gredesSum += sum;
                presentationCount++;
                presentation = Console.ReadLine();
            }
            double finalAverage = gredesSum / (presentationCount * juriesCount);
            Console.WriteLine($"Student's final assessment is {finalAverage:f2}.");
        }
    }
}
