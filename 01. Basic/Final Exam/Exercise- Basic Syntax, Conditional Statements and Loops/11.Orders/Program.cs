using System;
using System.Xml.Schema;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsuleCount = int.Parse(Console.ReadLine());

            decimal price = 0;
            decimal totalPrice = 0;

            while (ordersCount > 0)
            {
                price = pricePerCapsule * days * capsuleCount;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                ordersCount--;
                if (ordersCount > 0)
                {
                    pricePerCapsule = decimal.Parse((Console.ReadLine()));
                    days = int.Parse(Console.ReadLine());
                    capsuleCount = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
