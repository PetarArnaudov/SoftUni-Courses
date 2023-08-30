using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double requiredMoney = double.Parse(Console.ReadLine());
            double currentBalance = double.Parse(Console.ReadLine());
            int totalDaysCount = 0;
            int conseutiveSpendOperations = 0;
            while (currentBalance < requiredMoney && conseutiveSpendOperations < 5) 
            { 
                string operationType = Console.ReadLine();
                double operationAmount = double.Parse(Console.ReadLine());

                if (operationType == "save")
                {
                    conseutiveSpendOperations = 0;
                    currentBalance += operationAmount;
                }
                else if (operationType == "spend")
                {
                    conseutiveSpendOperations++;
                    currentBalance -= operationAmount;
                    currentBalance = Math.Max(0, currentBalance);
                }

                totalDaysCount++;
            }

            if (currentBalance >= requiredMoney)
            {
                Console.WriteLine($"You saved the money for {totalDaysCount} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(totalDaysCount);
            }
        }
    }
}
