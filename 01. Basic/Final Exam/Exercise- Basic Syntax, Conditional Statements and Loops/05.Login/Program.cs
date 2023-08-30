using System;
using System.Linq;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] userNameReverser = username.ToCharArray();
            Array.Reverse(userNameReverser);
            string password = new string(userNameReverser);


            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (i == 3 && input != password)
                {
                    Console.WriteLine($"User { username} blocked!");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                

            }
        }
    }
}
