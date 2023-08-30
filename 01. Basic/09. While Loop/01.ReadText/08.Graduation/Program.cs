using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sumGrades = 0.0;
            int grade = 1;
            int badGrades = 0;

            while (grade <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade < 4.0)
                {
                    badGrades++;

                    if (badGrades > 1)
                    {
                        break;
                    } 
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    grade++;
                    sumGrades += currentGrade;
                }
            }

            if (badGrades > 1)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumGrades / 12.0:f2}");
            }
        }
    }
}
