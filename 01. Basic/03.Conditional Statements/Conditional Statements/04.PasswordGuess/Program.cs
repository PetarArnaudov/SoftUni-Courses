using System;

namespace _04.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            if (n == "s3cr3t!P@ssw0rd") {
                Console.WriteLine("Welcome");
            } else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
