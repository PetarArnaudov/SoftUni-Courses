using System;

namespace _11.OddEvenPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0, evenSum = 0, oddMin = double.MaxValue, evenMin = double.MaxValue, oddMax = double.MinValue, evenMax = double.MinValue;


            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (evenMax < number)
                    {
                        evenMax = number;
                    }
                    if (evenMin > number)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if(oddMax < number)
                    {
                        oddMax = number;
                    }
                    if (oddMin > number)
                    {
                        oddMin = number;
                    }
                }
            }


            if (n == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 1)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }

        }
    }
}
