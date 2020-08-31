using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double usedMoney = 0;
            string destination = "";
            string place = "";


            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    usedMoney = budget * 30.0 / 100.0;
                }
                else
                {
                    place = "Hotel";
                    usedMoney = budget * 70.0 / 100.0;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    usedMoney = budget * 40.0 / 100.0;
                    place = "Camp";
                }
                else
                {
                    place = "Hotel";
                    usedMoney = budget * 80.0 / 100.0;
                }
            }

            else
            {
                destination = "Europe";
                usedMoney = budget * 90.0 / 100.0;
                place = "Hotel";
            }


            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {usedMoney:f2}");
        }
    }
}
