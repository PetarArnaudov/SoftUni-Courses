﻿using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1, position = 1;
            for (int i = 1; i <= n; i++)
            {

                Console.Write(i);
                if (position == row)
                {
                    Console.WriteLine();
                    row++;
                    position = 1;
                }
                else
                {
                    Console.Write(" ");
                    position++;
                }
            }
        }
    }
}
