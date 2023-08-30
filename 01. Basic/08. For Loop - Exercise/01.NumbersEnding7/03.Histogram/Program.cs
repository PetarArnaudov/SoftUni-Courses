﻿using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int currNumm = int.Parse(Console.ReadLine());

                if (currNumm < 200)
                {
                    p1++;
                }
                else if (currNumm < 400)
                {
                    p2++;
                }
                else if ( currNumm < 600)
                {
                    p3++;
                }
                else if (currNumm < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            Console.WriteLine($"{(p1 * 100.0) / n:f2}%");
            Console.WriteLine($"{(p2 * 100.0) / n:f2}%");
            Console.WriteLine($"{(p3 * 100.0) / n:f2}%");
            Console.WriteLine($"{(p4 * 100.0) / n:f2}%");
            Console.WriteLine($"{(p5 * 100.0) / n:f2}%");
        }
    }
}
