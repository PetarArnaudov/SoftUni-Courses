using System;

namespace _03.LuckyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for(int k = 1; k < 10; k++)
                    {
                        for (int l = 1; l < 10; l++)
                        {
                            if (n % (i+j) == 0 && (i + j) == (k + l))
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
