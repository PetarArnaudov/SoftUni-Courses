using System;

namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                else
                {
                    int number = int.Parse(input);

                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}


