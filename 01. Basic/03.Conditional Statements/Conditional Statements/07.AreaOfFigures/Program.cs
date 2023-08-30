using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string n = Console.ReadLine();

            if (n == "square")
            {
                double a = double.Parse(Console.ReadLine());
                
                Console.WriteLine(Math.Round(a*a, 3));
            }
            else if (n == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(a*b, 3));
            } 
            else if (n == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                
                Console.WriteLine("{0:F3}", Math.PI * Math.Pow(a, 2));
            } 
            else if (n == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(a*b/2, 3));
            }
        }
        
    }
}
