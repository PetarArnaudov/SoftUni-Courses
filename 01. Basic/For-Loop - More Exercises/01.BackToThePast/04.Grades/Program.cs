using System;

namespace _04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int student = int.Parse(Console.ReadLine());
            double sum = 0;
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0;

            for (int i = 0; i < student; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sum += grade;

                if (grade >= 5.00)
                {
                    p1++;
                }
                else if (grade >= 4.00)
                {
                    p2++;
                }
                else if (grade >=3.00)
                {
                    p3++;
                }
                else
                {
                    p4++;
                }

            }


            Console.WriteLine($"Top students: {(p1 * 100.0) / student:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(p2 * 100.0) / student:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(p3 * 100.0) / student:f2}%");
            Console.WriteLine($"Fail: {(p4 * 100.0) / student:f2}%");
            Console.WriteLine($"Average: {sum / student:f2}");
        }
    }
}
