using System;

namespace _02.LettersCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char forbiLetter = char.Parse(Console.ReadLine());

            int firstLetterCode = Convert.ToInt32(firstLetter);
            int secondLetterCode = Convert.ToInt32(secondLetter);
            int forbiLetterCode = Convert.ToInt32(forbiLetter);
            int counter = 0;

            for (int i = firstLetterCode; i <= secondLetterCode; i++)
            {
                for (int j = firstLetterCode; j <= secondLetterCode; j++)
                {
                    for (int k = firstLetterCode; k <= secondLetterCode; k++)
                    {
                        if (i != forbiLetterCode && j != forbiLetterCode && k != forbiLetterCode)
                        {
                            Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(k)} ");
                            counter++;
                        }
                    }
                }
            }

            Console.Write(counter);
        }
    }
}
