using System;

namespace _07.FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            int a = 0, b = 0, v = 0, g = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    a++;        
                }
                else if (sector == "B")
                {
                    b++;
                }
                else if (sector == "V")
                {
                    v++;
                }
                else
                {
                    g++;
                }
            }

            Console.WriteLine($"{(a * 100.0) / fans:f2}%");
            Console.WriteLine($"{(b * 100.0) / fans:f2}%");
            Console.WriteLine($"{(v * 100.0) / fans:f2}%");
            Console.WriteLine($"{(g * 100.0) / fans:f2}%");
            Console.WriteLine($"{((a + b + v + g) * 100.0) / capacity:f2}%");
        }
    }
}
