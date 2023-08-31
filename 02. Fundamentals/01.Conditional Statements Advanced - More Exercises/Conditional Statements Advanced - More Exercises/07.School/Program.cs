using System;

namespace _07.School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seson = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = 0;
            double finalPrice = 0;
            string sportType = "";

            if (group == "boys")
            {

                if (seson == "Winter")
                {
                    nightPrice = 9.60;
                    sportType = "Judo";
                }
                else if (seson == "Spring")
                {
                    nightPrice = 7.20;
                    sportType = "Tennis";
                }
                else //Summer
                {
                    nightPrice = 15;
                    sportType = "Football";
                }
            }
            else if (group == "girls")
            {
                if (seson == "Winter")
                {
                    nightPrice = 9.60;
                    sportType = "Gymnastics";
                }
                else if (seson == "Spring")
                {
                    nightPrice = 7.20;
                    sportType = "Athletics";
                }
                else //Summer
                {
                    nightPrice = 15;
                    sportType = "Volleyball";
                }
            }
            else //mixed 
            {
                if (seson == "Winter")
                {
                    nightPrice = 10;
                    sportType = "Ski";
                }
                else if (seson == "Spring")
                {
                    nightPrice = 9.5;
                    sportType = "Cycling";
                }
                else //Summer
                {
                    nightPrice = 20;
                    sportType = "Swimming";
                }
            }

            finalPrice = nightPrice * students * nights;

            if (students >= 50)
            {
                finalPrice *= 0.50;
            }
            else if (students >= 20)
            {
                finalPrice *= 0.85;
            }
            else if (students >= 10)
            {
                finalPrice *= 0.95;
            }

            Console.WriteLine($"{sportType} {finalPrice:f} lv.");
        }
    }
}
