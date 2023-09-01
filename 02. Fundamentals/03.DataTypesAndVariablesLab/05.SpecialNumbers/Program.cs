using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool specialNumber = false;

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int digitsSum = 0;
                while (number != 0)
                {
                    digitsSum += number % 10;
                    number /= 10;
                }
                if (digitsSum == 5 || digitsSum == 7 || digitsSum == 11)
                {
                    specialNumber = true;
                }

                Console.WriteLine($"{i} -> {specialNumber}");
                specialNumber = false;
            }
        }
    }
}
