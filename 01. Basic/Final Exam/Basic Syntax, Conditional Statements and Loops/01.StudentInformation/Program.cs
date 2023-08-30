using System;

namespace _01.StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double avGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {avGrade:f2}");
        }
    }
}
