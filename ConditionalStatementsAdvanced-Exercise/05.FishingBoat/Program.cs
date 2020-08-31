using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgetGroup = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenNumber = int.Parse(Console.ReadLine());

            double price = 0;
            double bonusDiscount = 0.95;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    if (fishermenNumber <= 6)
                    {
                        price = price * 0.90;
                    }
                    else if (7 <= fishermenNumber && fishermenNumber <= 11)
                    {
                        price = price * 0.85;
                    }
                    else if (fishermenNumber > 12)
                    {
                        price = price * 0.75;
                    }
                    break;

                case "Summer":
                    price = 4200;
                    if (fishermenNumber <= 6)
                    {
                        price = price * 0.90;
                    }
                    else if (7 <= fishermenNumber && fishermenNumber <= 11)
                    {
                        price = price * 0.85;
                    }
                    else if (fishermenNumber > 12)
                    {
                        price = price * 0.75;
                    }
                    break;

                case "Autumn":
                    price = 4200;
                    if (fishermenNumber <= 6)
                    {
                        price = price * 0.90;
                    }
                    else if (7 <= fishermenNumber && fishermenNumber <= 11 )
                    {
                        price = price * 0.85;
                    }
                    else if (fishermenNumber > 12)
                    {
                        price = price * 0.75;
                    }
                    break;

                case "Winter":
                    price = 2600;
                    if (fishermenNumber <= 6)
                    {
                        price = price * 0.90;
                    }
                    else if (7 <= fishermenNumber && fishermenNumber <= 11)
                    {
                        price = price * 0.85;
                    }
                    else if (fishermenNumber > 12 )
                    {
                        price = price * 0.75;
                    }
                    break;
            }

            if (fishermenNumber % 2 == 0 && season != "Autumn")
            {
                price = price * bonusDiscount;
            }

            if (budgetGroup >= price)
            {
                Console.WriteLine($"Yes! You have {budgetGroup - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budgetGroup:f2} leva.");
            }
        }
    }
}
