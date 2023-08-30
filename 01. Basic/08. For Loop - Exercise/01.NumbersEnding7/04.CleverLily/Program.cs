using System;
using System.Threading;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toysCount = 0;
            double savedMoney = 0;
           

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0 )
                {
                    savedMoney += i * 5 - 1;
                }
                else
                {
                    toysCount++;
                }
            }

            savedMoney += toysCount * toyPrice;

            if(savedMoney >= washingPrice) 
            {
                Console.WriteLine($"Yes! {savedMoney-washingPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingPrice - savedMoney:f2}");
            }
        }
    }
}
