using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operatorInput = Console.ReadLine();
            double result = 0;
            bool evenOrNot = false;

            if (operatorInput == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    evenOrNot = true;
                    Console.WriteLine($"{n1} + {n2} = {result} - even");
                } else
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - odd");
                }
                
            }
            else if (operatorInput == "-")
            {
                result = n1 - n2;
                
                if (result % 2 == 0)
                {
                    evenOrNot = true;
                    Console.WriteLine($"{n1} - {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - odd");
                }
            }
            else if (operatorInput == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - even");
                } else
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - odd");
                }
            } 
            else if (operatorInput == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = (double)n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
            } 
            else if (operatorInput == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }

        }
    }
}
