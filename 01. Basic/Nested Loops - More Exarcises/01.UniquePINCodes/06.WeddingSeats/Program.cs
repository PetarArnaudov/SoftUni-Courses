using System;

namespace _06.WeddingSeats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int firstSectorRows = int.Parse(Console.ReadLine());
            int oddRowsCount = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = Convert.ToInt32('A'); i <= Convert.ToInt32(lastSector); i++)
            {
                for (int j = 1; j <= firstSectorRows; j++)
                {
                    for(int k = 1; k <= oddRowsCount + 2; k++)
                    {
                        if(j % 2 != 0 && k > oddRowsCount)
                        {
                            break;
                        }
                        Console.WriteLine($"{Convert.ToChar(i)}{j}{Convert.ToChar(k + 96)}");
                        counter++;
                    }
                }
                
                firstSectorRows++;
            }
            Console.WriteLine(counter);

        }
    }
}
