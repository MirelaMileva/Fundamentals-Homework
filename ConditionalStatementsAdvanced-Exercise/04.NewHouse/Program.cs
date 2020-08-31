using System;

namespace _04.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowerNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowerPrice = 0;

            switch (flower)
            {
                case "Roses":
                    flowerPrice = 5;
                    if (flowerNumber > 80)
                    {
                        flowerPrice = flowerPrice * 0.90;
                    }
                    break;
                case "Dahlias":
                    flowerPrice = 3.80;
                    if (flowerNumber > 90)
                    {
                        flowerPrice = flowerPrice * 0.85;                    }
                    break;
                case "Tulips":
                    flowerPrice = 2.80;
                     if (flowerNumber > 80)
                    {
                        flowerPrice = flowerPrice * 0.85;
                    }
                    break;
                case "Narcissus":
                    flowerPrice = 3;
                    if (flowerNumber < 120)
                    {
                        flowerPrice = flowerPrice * 1.15;
                    }
                    break;
                case "Gladiolus":
                    flowerPrice = 2.50;
                    if (flowerNumber < 80)
                    {
                        flowerPrice = flowerPrice * 1.20;
                    }
                    break;
            }
            

            double totalPrice = flowerPrice * flowerNumber;

            if (budget >= totalPrice )
            {
                double amountLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerNumber} {flower} and {amountLeft:f2} leva left.");
            }

            else 
            {
                double amountNeed = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {amountNeed:f2} leva more.");
            }
        }
    }
}
