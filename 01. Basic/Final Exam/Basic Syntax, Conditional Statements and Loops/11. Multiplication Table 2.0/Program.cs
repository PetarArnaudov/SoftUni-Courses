using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multipller = int.Parse(Console.ReadLine());

            for (int i = multipller; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }

            if (multipller > 10)
            {
                Console.WriteLine($"{number} X {multipller} = {number * multipller}");
            }
        }
    }
}
