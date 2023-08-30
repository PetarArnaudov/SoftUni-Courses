using System;
using System.Text;

namespace _07._SafePasswordsGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxGeneratedPasswords = int.Parse(Console.ReadLine());

            int outputA = 35;
            int outputB = 64;
            int counter = 1;

            for (int i = 1; i <= a; i++)
            {
                if (maxGeneratedPasswords < 1)
                {
                    break;
                }
                for (int j = 1; j <= b; j++)
                {
                    if (outputA > 55)
                    {
                        outputA = 35;
                    }
                    if (outputB > 96)
                    {
                        outputB = 64;
                    }

                    Console.Write($"{Convert.ToChar(outputA)}{Convert.ToChar(outputB)}{i}{j}{Convert.ToChar(outputB)}{Convert.ToChar(outputA)}|");
                    counter++;
                    outputA++;
                    outputB++;
                    
                    if (counter > maxGeneratedPasswords)
                    {
                        break;
                    }

                }
                if (counter > maxGeneratedPasswords)
                {
                    break;
                }
            }
           
            
        }
    }
}
