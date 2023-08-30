using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double TotalMaterialsPrice = (nylon + 2) * 1.5 + paint * 1.1 * 14.50 + diluent * 5 + 0.40;
            double workPrice = TotalMaterialsPrice * 0.3 * hours;
            Console.WriteLine(workPrice + TotalMaterialsPrice);

        }
    }
}
