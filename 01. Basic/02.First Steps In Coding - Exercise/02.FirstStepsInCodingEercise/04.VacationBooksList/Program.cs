using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            int readingSpeed = int.Parse(Console.ReadLine());
            int daysLeft = int.Parse(Console.ReadLine());

            Console.WriteLine((pagesInBook / readingSpeed) / daysLeft);
        }
    }
}
