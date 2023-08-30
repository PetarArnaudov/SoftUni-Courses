using System;
using System.Diagnostics.CodeAnalysis;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            double nuts = 2;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1;
            

            while (input != "Start" && input != "End")
            {
                double coins = double.Parse(input);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }

            if (input == "Start")
            {
                string product = Console.ReadLine();
                while (product != "End")
                {
                    
                    
                    switch (product)
                    {
                        case "Nuts":
                            if (sum >= nuts)
                            {
                                Console.WriteLine($"Purchased nuts");
                                sum -= nuts;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }

                            break;
                        case "Water":
                            if (sum >= water)
                            {
                                Console.WriteLine($"Purchased water");
                                sum -= water;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Crisps":
                            if (sum >= crisps)
                            {
                                Console.WriteLine($"Purchased crisps");
                                sum -= crisps;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Soda":
                            if (sum >= soda)
                            {
                                Console.WriteLine($"Purchased soda");
                                sum -= soda;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Coke":
                            if (sum >= coke)
                            {
                                Console.WriteLine($"Purchased coke");
                                sum -= coke;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }
                    
                    product = Console.ReadLine();
                }
            }

            Console.WriteLine($"Change: {sum:f2}");

        }
    }
}
