﻿using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
            while (input != "stop")
            {
                int number = int.Parse(input);
                

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    if (number < 2)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        double sqrt = Math.Sqrt(number);
                        for (int i = 2; i <= sqrt; i++)
                        {
                            if (number % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime) { primeSum += number; }
                        else { nonPrimeSum += number; }

                    }

                    
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");




        }
    }
}
