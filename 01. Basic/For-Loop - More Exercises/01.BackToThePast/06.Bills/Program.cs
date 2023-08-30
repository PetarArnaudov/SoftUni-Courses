using System;

namespace _06.Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double elBill = 0.0;
            double waterBill = 20 * months;
            double internetBill = 15 * months;
            double otherBill = 0.0;

            for (int i = 0; i < months; i++)
            {
                double bill = double.Parse(Console.ReadLine());
                elBill += bill;

            }
            otherBill = (elBill + waterBill + internetBill) * 1.2;



            Console.WriteLine($"Electricity: {elBill:f2} lv");
            Console.WriteLine($"Water: {waterBill:f2} lv");
            Console.WriteLine($"Internet: {internetBill:f2} lv");
            Console.WriteLine($"Other: {otherBill:f2} lv");
            Console.WriteLine($"Average: {(elBill+waterBill+internetBill+otherBill) / months:f2} lv");


        }
    }
}
