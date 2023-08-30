using System;

namespace _14.PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int a = 1; a < n; a++)
                {
                    for (int j = 'a'; j < 'a' + l; j++)
                    {
                        for (int k = 'a'; k < 'a' + l; k++)
                        {
                            for (int b = i + 1; b <= n; b++)
                            {
                                if (b > i && b > a)
                                {
                                    Console.Write($"{i}{a}{Convert.ToChar(j)}{Convert.ToChar(k)}{b} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
