using System;

namespace _09.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            examMinutes += examHour * 60;
            arrivalMinutes += arrivalHour * 60;

            if (arrivalMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                int difference = arrivalMinutes - examMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    int h = difference / 60;
                    int m = difference % 60;
                    Console.WriteLine($"{h}:{m:d2} hours after the start");
                }
            }

            else if (arrivalMinutes < examMinutes - 30)

            {
                Console.WriteLine("Early");
                int difference = examMinutes - arrivalMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    int h = difference / 60;
                    int m = difference % 60;
                    Console.WriteLine($"{h}:{m:d2} hours before the start");
                }
            }

            else
            {
                Console.WriteLine("On time");
                int difference = examMinutes - arrivalMinutes;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
