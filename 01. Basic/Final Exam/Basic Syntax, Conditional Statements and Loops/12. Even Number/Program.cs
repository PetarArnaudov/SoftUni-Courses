using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool oddNumber = true;

            while (oddNumber)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    oddNumber = false;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    number = int.Parse(Console.ReadLine());
                }
                
            }
        }
    }
}
