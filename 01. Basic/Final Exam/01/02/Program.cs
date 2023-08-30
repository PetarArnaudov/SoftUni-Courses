using System;

namespace _02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodInKg = int.Parse(Console.ReadLine());
            double firstAnimalFood = double.Parse(Console.ReadLine());
            double secondAnimalFood = double.Parse(Console.ReadLine());
            double thirdAnimalFood = double.Parse(Console.ReadLine());

            firstAnimalFood *= days;
            secondAnimalFood *= days;
            thirdAnimalFood *= days;

            double neededFood = firstAnimalFood + secondAnimalFood + thirdAnimalFood;


            if (foodInKg > neededFood)
            {
                Console.WriteLine($"{Math.Floor(foodInKg - neededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(neededFood - foodInKg)} more kilos of food are needed.");
            }
        }
    }
}
