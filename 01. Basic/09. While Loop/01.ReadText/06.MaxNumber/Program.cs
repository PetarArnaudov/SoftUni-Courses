using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bigestNumber = int.MinValue;
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

                    if (number > bigestNumber)
                    {
                        bigestNumber = number;
                    }
                }
            }

            Console.WriteLine(bigestNumber);
        }
    }
}
