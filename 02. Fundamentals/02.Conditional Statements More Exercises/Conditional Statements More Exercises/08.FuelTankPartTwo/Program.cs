using System;

namespace _08.FuelTankPartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 	Бензин – 2.22 лева за един литър, 
                Дизел – 2.33 лева за един литър
	                       
             Ако водача има карта за отстъпки,  той се възползва от следните намаления за литър гориво: 18 ст. за литър бензин, 12 ст. за литър дизел и 8 ст. за литър газ. 
            
             Ако шофьора е заредил между 20 и 25 литра включително, 
            той получава 8 процента отстъпка от крайната цена, при повече от 25 литра гориво, той получава 10 процента отстъпка от крайната цена.
             */

            string fuelType = Console.ReadLine();
            double fuel = double.Parse(Console.ReadLine());
            string bonusCard = Console.ReadLine();
            double totalPrice = 0.0;

            if (fuelType == "Gas")
            {
                totalPrice = fuel * 0.93;
                if (bonusCard == "Yes")
                {
                    totalPrice -= fuel * 0.08;
                }
            } 
            else if (fuelType == "Gasoline")
            {
                totalPrice = fuel * 2.22;
                if(bonusCard == "Yes")
                {
                    totalPrice -= fuel * 0.18;
                }
            } 
            else
            {
                totalPrice = fuel * 2.33;
                if (bonusCard == "Yes")
                {
                    totalPrice -= fuel * 0.12;
                }
            }

            if (fuel >= 20 && fuel <= 25)
            {
                totalPrice *= 0.92;
            }
            else if (fuel > 25)
            {
                totalPrice *= 0.9;
            }



            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
