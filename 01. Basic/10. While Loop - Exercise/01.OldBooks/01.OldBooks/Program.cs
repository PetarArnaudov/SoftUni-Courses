﻿using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();

            int checkedBooks = 0;
            bool isFound = false;
            string currentBook = Console.ReadLine();
            while (currentBook != "No More Books")
            {
                if (currentBook == book)
                {
                    isFound = true;
                    break;
                }

                checkedBooks++;
                currentBook = Console.ReadLine();
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}
