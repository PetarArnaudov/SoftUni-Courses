using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seconds1 = int.Parse(Console.ReadLine());
            int seconds2 = int.Parse(Console.ReadLine());
            int seconds3 = int.Parse(Console.ReadLine());

            int totalSeconds = seconds1 + seconds2 + seconds3;

            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            } else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
