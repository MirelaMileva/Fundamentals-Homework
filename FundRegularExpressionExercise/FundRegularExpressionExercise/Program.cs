using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FundRegularExpressionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furnitures = new List<string>();
            decimal totalMoney = 0.0m;

            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            string input;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match matches = Regex.Match(input, pattern);

                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    decimal price = decimal.Parse(matches.Groups["price"].Value);
                    long quantity = long.Parse(matches.Groups["quantity"].Value);

                    furnitures.Add(name);
                    totalMoney += price * quantity;
                }

            }

            Console.WriteLine("Bought furniture: ");
            foreach (var name in furnitures)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
