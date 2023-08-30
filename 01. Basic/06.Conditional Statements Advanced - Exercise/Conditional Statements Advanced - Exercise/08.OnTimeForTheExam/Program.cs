using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;

            string state = "";
            string keyword = "";
            if (arrivalTime > examTime)
            {
                state = "Late";
                keyword = "after";
            }
            else if (arrivalTime >= examTime - 30)
            {
                state = "On time";
                keyword = "before";
            }
            else
            {
                state = "Early";
                keyword = "before";
            }

            int diff = Math.Abs(examTime - arrivalTime);

            string formattedDiff = "";

            if (diff >= 60)
            {
                int diffHour = diff / 60;
                int diffMinutes = diff % 60;

                if (diffMinutes < 10)
                {
                    formattedDiff = $"{diffHour}:0{diffMinutes} hours";
                }
                else
                {
                    formattedDiff = $"{diffHour}:{diffMinutes} hours";
                }
            }
            else
            {
                formattedDiff = $"{diff} minutes";
            }

            Console.WriteLine(state);
            if (diff != 0)
            {
                Console.WriteLine($"{formattedDiff} {keyword} the start");
            }
        }
    }
}
