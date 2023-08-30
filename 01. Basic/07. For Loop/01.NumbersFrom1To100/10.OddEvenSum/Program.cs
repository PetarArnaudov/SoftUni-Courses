using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  

            int oddSum = 0;
            int evenSum = 0;


            for (int i = 1; i <= n; i++)
            {

                int curNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += curNum;
                }
                else
                {
                    oddSum += curNum;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
