using System;

namespace _03._SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < number)
            {
                int currNum = int.Parse(Console.ReadLine());
                sum += currNum;
            }

            Console.WriteLine(sum);
        }
    }
}
