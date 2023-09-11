using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yeald = int.Parse(Console.ReadLine());
            int days = 0;
            int spice = 0;

            while (yeald >= 100)
            {
                days++;
                spice += yeald;
                spice -= 26;
                yeald -= 10; 
            }
            spice -= 26;

            if (spice < 0)
            {
                spice = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(spice);
        }
    }
}
