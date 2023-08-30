using System;
using System.Transactions;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingPrice = int.Parse(Console.ReadLine());

            double shoes = trainingPrice * 0.6;
            double clothes = shoes * 0.8;
            double ball = clothes * 0.25;
            double accessories = ball * 0.2;

            Console.WriteLine(shoes + clothes + ball + accessories + trainingPrice);

        }
    }
}
