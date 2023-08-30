using System;
using System.Threading;

namespace _05._ChallengeWedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mens = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 1; i <= mens; i++)
            {
                for(int j = 1; j <= women; j++)
                {
                    if (counter <= max)
                    {
                        Console.Write($"({i} <-> {j}) ");
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
