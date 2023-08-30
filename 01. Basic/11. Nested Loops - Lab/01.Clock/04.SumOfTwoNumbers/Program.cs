using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool founded = false;

            for (int i = start; i <= end; i++)
            {
                for (int k = start; k <= end; k++)
                {
                    counter++;
                    if (i + k == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {k} = {magicNumber})");
                        founded = true;
                        break;                    
                    }
                    
                }
                if(founded)
                {
                    break;
                }
            }

            if (!founded)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
