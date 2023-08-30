using System;
using System.Transactions;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int chalkboardCleaner = int.Parse(Console.ReadLine());
            int discountProcent = int.Parse(Console.ReadLine());
            double newDiscountProcent = discountProcent * 0.01;
            double pensPrice = pens * 5.80;
            double markersPrice = 7.20 * markers;
            double cleanerPrice = 1.20 * chalkboardCleaner;
            double totalPrice = pensPrice + markersPrice + cleanerPrice;


            Console.WriteLine(totalPrice - (totalPrice * newDiscountProcent));

        }
    }
}
