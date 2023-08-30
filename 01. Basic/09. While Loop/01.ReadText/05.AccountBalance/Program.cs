using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalAmount = 0.0;

            while (input != "NoMoreMoney")
            {
                double number = double.Parse(input);

                if (number < 0 )
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {number:f2}");
                totalAmount += number;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalAmount:f2}");
        }
    }
}
