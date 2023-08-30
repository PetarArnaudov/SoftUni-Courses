using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double totalPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            
             

            for (int i = 0; i < n && totalPoints < 1250.5; i++)
            {
                string judgeName = Console.ReadLine();
                double newPoints = double.Parse(Console.ReadLine());

                totalPoints += (judgeName.Length * newPoints) / 2;
            }

            if (totalPoints > 1250.5) 
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - totalPoints:f1} more!");
            }

        }
    }
}
