using System;

namespace _08.EqualPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number1 = 0, number2 = 0, sum = 0, firstSum = 0;
            bool equals = true;
            int maxDiff = 0;

            for (int i = 0, j = 0; i < n; i++)
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());

                sum = number1 + number2;
                
                if (i == 0) { firstSum =  sum; }
                else if (firstSum != sum) { equals = false; }

                if (i > 0 && maxDiff < Math.Abs(j - sum))
                {
                    maxDiff = Math.Abs(j - sum);
                }

                j = sum;
                
            }
            
            if (equals || n == 1)
            {
                Console.WriteLine($"Yes, value={firstSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }

        }
    }
}
