using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double income = 0;

            if (projectionType == "Premiere")
            {
                income = row * column * 12;

            }
            else if (projectionType == "Normal")
            {
                income = row * column * 7.50;
            }
            else if (projectionType == "Discount")
            {
                income = row * column * 5;
            }

            Console.WriteLine($"{income:f2} leva");
            
        }
    }
}
