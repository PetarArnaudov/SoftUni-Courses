using System;

namespace _06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Георги ще има гости вечерта и решава да ги нагости с паламуд, сафрид и миди. Затова отива на рибната борса, за да си купи по няколко килограма.
            * Oт конзолата се въвеждат цените в лева на скумрията и цацата.Също количеството на паламуд, сафрид и миди в килограми. 
            * Колко пари ще са му необходими, за да плати сметката си, ако цените на борсата са:
            •	Паламуд – 60 % по - скъп от скумрията
            •	Сафрид – 80 % по - скъп от цацата
            •	Миди – 7.50 лв.за килограм */


            double mackerelPrice = double.Parse(Console.ReadLine());
            double sprinklePrice = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int musselsKg = Int32.Parse(Console.ReadLine());

            double bonitoPrice = mackerelPrice * 1.6;
            double safridPrice = sprinklePrice * 1.8;

            double finalPrice = bonitoPrice * bonitoKg + safridKg * safridPrice + musselsKg * 7.50;

            Console.WriteLine("{0:F2}", finalPrice);

        }
    }
}
