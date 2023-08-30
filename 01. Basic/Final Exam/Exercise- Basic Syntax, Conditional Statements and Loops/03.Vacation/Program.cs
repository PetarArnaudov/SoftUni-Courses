using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayofWeek = Console.ReadLine();

            float totalPrice = 0;

            switch (groupType)
            {
                case "Students":
                    switch (dayofWeek)
                    {
                        case "Friday":
                            totalPrice += peopleCount * 8.45f;
                            break;
                        case "Saturday":
                            totalPrice += peopleCount * 9.80f;
                            break;
                        case "Sunday":
                            totalPrice += peopleCount * 10.46f;
                            break;
                    }

                    if (peopleCount >= 30)
                    {
                        totalPrice *= 0.85f;
                    }
                    break;

                case "Business":
                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                    }
                    switch (dayofWeek)
                    {
                        case "Friday":
                            totalPrice += peopleCount * 10.90f;
                            break;
                        case "Saturday":
                            totalPrice += peopleCount * 15.60f;
                            break;
                        case "Sunday":
                            totalPrice += peopleCount * 16f;
                            break;
                    }

                    break;

                case "Regular":
                    switch (dayofWeek)
                    {
                        case "Friday":
                            totalPrice += peopleCount * 15f;
                            break;
                        case "Saturday":
                            totalPrice += peopleCount * 20f;
                            break;
                        case "Sunday":
                            totalPrice += peopleCount * 22.50f;
                            break;
                    }
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalPrice *= 0.95f;
                    }
                    break;

                    
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
