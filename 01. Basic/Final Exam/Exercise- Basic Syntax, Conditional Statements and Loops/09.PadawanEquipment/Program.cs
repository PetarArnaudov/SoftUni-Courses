using System;
using System.Drawing;
using System.Reflection.Emit;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double johnsMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double cost = 0;

            priceOfLightsabers *= Math.Ceiling(studentsCount * 1.1);
            priceOfRobes *= studentsCount;

            int freeBelts = studentsCount / 6;
            priceOfBelts *= (studentsCount - freeBelts);

            cost = priceOfRobes + priceOfLightsabers + priceOfBelts;

            if (cost <= johnsMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {cost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {cost-johnsMoney:f2}lv more.");
            }
        }
    }
}
