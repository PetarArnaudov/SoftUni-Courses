using System;

namespace _07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
           

            double walls = 2 * x * x - 1.2 * 2 + 2 * x * y - 2 * 1.5 * 1.5;
            double roof = 2 * x * y + 2*((x*h)/2);

            double greenPaint = walls / 3.4;
            double redPaint = roof / 4.3;

            Console.WriteLine("{0:F2}", greenPaint);
            Console.WriteLine("{0:F2}", redPaint);
        }
    }
}
