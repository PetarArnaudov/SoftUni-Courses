using System;
using System.IO;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newN = n;
            string numLen = n.ToString();
            int sum = 0;
            bool end = false;
            int facSum = 1;

            for (int i = 0; i < numLen.Length; i++)
            {
                int curr = newN % 10;
                newN = newN / 10;
                
                for (int j = 1; j <= curr; j++)
                {
                    facSum *= j;
                }
                sum += facSum;
                facSum = 1;
            }
            
            if (sum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
