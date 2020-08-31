using System;

namespace _08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceApartment = 0;
            double priceStudio = 0;

            switch (month)
            {
                case "May":
                case "October":

                    priceApartment = 65;
                    priceStudio = 50;

                    if (nights > 14)
                    {
                        priceStudio *= 0.70;
                        priceApartment *= 0.90;
                    }
                    else if (nights > 7)
                    {
                        priceStudio *= 0.95;
                    }

                    break;

                case "June":
                case "September":

                    priceApartment = 68.70;
                    priceStudio = 75.20;

                    if (nights > 14)
                    {
                        priceStudio *= 0.80;
                        priceApartment *= 0.90;
                    }
                    break;

                case "July":
                case "August":

                    priceApartment = 77;
                    priceStudio = 76;

                    if (nights > 14)

                    {

                        priceApartment *= 0.90;
                    }

                    break;
            }




            Console.WriteLine($"Apartment: {(priceApartment * nights):f2} lv.");
            Console.WriteLine($"Studio: {(priceStudio * nights):f2} lv.");

        }
    }
}
