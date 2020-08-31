using System;

namespace _10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double yearWeekend = 48;
            double weekendSofia = yearWeekend - h;

            double playInSofia = weekendSofia * 0.75 ;
            double playOnVacantion = (p * 2) / 3;

            double totalPlay = playInSofia + h + playOnVacantion;

            if (yearType == "leap")
            {
                double morePlay = Math.Round(totalPlay * 0.15 , 3);
                double leapTotalPlay = (morePlay + totalPlay);
                Console.WriteLine($"{Math.Floor(leapTotalPlay)}");
            }

            else
            {
                
                Console.WriteLine($"{Math.Floor(totalPlay)}");
            }


        }
    }
}
