using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxBadGradesCount = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int badGradesCount = 0;
            int gradesSum = 0;
            int problemsCount = 0;
            string lastProblem = "";
            bool failed = false;


            while (input != "Enough") 
            {
                 
                int grade = int.Parse(Console.ReadLine());
                
                problemsCount++;
                gradesSum += grade;
                lastProblem = input;

                if (grade <= 4)
                {
                    badGradesCount++;
                    if (badGradesCount == maxBadGradesCount)
                    {
                        failed = true;
                        break;
                    }
                }
                
                input = Console.ReadLine();
            }

            double average = 1.0 * gradesSum / problemsCount;
            if (!failed)
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {problemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }
        }
    }
}
