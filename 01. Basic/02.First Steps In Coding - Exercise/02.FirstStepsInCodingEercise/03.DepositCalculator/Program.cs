using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double sum = deposit + period * ((deposit * (percent / 100)) / 12);

            Console.WriteLine(sum);
        }
    }
}
