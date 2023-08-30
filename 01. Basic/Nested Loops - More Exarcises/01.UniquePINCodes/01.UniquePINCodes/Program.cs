using System;

namespace _01.UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());
            bool isUnic = true;

            for (int i = 2; i <= firstDigit; i++)
            {
                for (int j = 2; j <= secondDigit; j++)
                {
                    
                    for (int k = 2; k <= thirdDigit; k++)
                    {
                        if (k % 2 != 0) { isUnic = false; }
                        if (j == 4 || j == 6 || j == 8 || j == 9)
                        {
                            isUnic = false;
                        }
                        if (i % 2 != 0) { isUnic = false; }
                        if (isUnic)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                        isUnic = true;
                    }

                }

                
            }
        }
    }
}
