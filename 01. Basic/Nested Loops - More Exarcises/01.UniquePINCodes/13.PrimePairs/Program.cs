using System;

namespace _13.PrimePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int aEnd = int.Parse(Console.ReadLine());
            int bEnd = int.Parse(Console.ReadLine());

            bool firstIsPrime = true;
            bool secondIsPrime = true;

            for (int i = a; i <= a + aEnd; i++)
            {
                for (int j = b; j <= b + bEnd; j++)
                {
                    
                    for (int k = 2; k < a / 2; k++)
                    {
                        if (i % k == 0)
                        {
                            firstIsPrime = false;
                        }
                    }
                    for (int l = 2; l < b / 2; l++)
                    {
                        if (j % l == 0)
                        {
                            secondIsPrime = false;
                        }
                    }
                    if (firstIsPrime && secondIsPrime)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                    else
                    {
                        firstIsPrime = true;
                        secondIsPrime = true;
                    }
                }
            }
        }
    }
}
