using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*0-2 – baby
            • 3-13 – child
            • 14-19 – teenager
            • 20-65 – adult
            • >= 66 – elder
             */

            int input = int.Parse(Console.ReadLine());

            if (input < 3)
            {
                Console.WriteLine("baby");
            }
            else if (input < 14)
            {
                Console.WriteLine("child");
            }
            else if (input < 20)
            {
                Console.WriteLine("teenager");
            }
            else if (input < 66)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
