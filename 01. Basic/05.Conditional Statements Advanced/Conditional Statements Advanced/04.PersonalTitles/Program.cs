using System;

namespace _04.PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gander = Console.ReadLine();

            if (age >= 16)
            {
                if (gander == "m")
                {
                    Console.WriteLine("Mr.");
                } else if (gander == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (gander == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (gander == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
