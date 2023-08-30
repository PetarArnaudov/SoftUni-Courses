using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney <= neededMoney)
                {
                    double currentMoney = double.Parse(Console.ReadLine());
                    savedMoney += currentMoney;

                    if (savedMoney >= neededMoney)
                    {
                        Console.WriteLine($"Going to {input}!");
                        break;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
