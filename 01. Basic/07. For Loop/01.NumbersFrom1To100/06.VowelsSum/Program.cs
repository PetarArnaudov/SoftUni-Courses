using System;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;int e = 2;int i = 3;int o = 4;int u = 5;

            int sum = 0;

            string text = Console.ReadLine();

            for (int j = 0; j < text.Length; j++)
            {
                if (text[j] == 'a')
                {
                    sum += a;
                }
                else if (text[j] == 'e')
                {
                    sum += e;
                } 
                else if (text[j] == 'i')
                {
                    sum += i;
                } else if (text[j] == 'o')
                {
                    sum += o;
                } else if (text[j] == 'u')
                {
                    sum += u;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
