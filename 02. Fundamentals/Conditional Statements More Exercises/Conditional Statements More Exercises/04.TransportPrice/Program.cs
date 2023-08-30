using System;

namespace _04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double sum = 0.0;

            if (n < 20)
            {
                sum += 0.70;
                if (dayOrNight == "day")
                {
                    sum += n * 0.79;
                }
                else
                {
                    sum += n * 0.90;
                } 
            } else if (n < 100)
            {
                sum += n * 0.09;
            } else
            {
                sum += n * 0.06;
            }

            Console.WriteLine("{0:f2}", sum);
        }
    }
}
