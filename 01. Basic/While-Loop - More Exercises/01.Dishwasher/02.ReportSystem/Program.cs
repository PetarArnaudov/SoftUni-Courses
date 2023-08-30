using System;
using System.Transactions;

namespace _02.ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyNeeded = int.Parse(Console.ReadLine());
            int counter = 1;
            int AverageCS = 0;
            int AverageCC = 0;
            bool enoughMoney = false;
            int counterCS = 0;
            int counterCC = 0;

            string input = Console.ReadLine();
            while (input != "End")
            {
                int currentTransaction = int.Parse(input);
                if (counter % 2 != 0)
                { // Cash
                    if (currentTransaction > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        AverageCS += currentTransaction;
                        counterCS++;
                    }
                } 
                else
                { // Card
                    if (currentTransaction < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        AverageCC += currentTransaction;
                        counterCC++;
                    }
                }

                if (AverageCS + AverageCC >= moneyNeeded)
                {
                    enoughMoney = true;
                    break;
                }

                counter++;
                input = Console.ReadLine();
            }

            if (enoughMoney)
            {
                Console.WriteLine($"Average CS: {1.0 * AverageCS / counterCS:f2}");
                Console.WriteLine($"Average CC: {1.0 * AverageCC / counterCC:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }


        }
    }
}
