using System;
using System.ComponentModel.Design;
using System.Timers;

namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char symbol = char.Parse(Console.ReadLine());
            
            if (symbol >= 65 && symbol <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
            
        }
    }
}
