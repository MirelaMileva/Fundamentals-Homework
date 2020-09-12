using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participans = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> participansAndDistance = new Dictionary<string, int>();

            string namePattern = @"[A-Za-z]";
            string digitPattern = @"\d";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                var nameMatch = Regex.Matches(input, namePattern);
                var distanceMatch = Regex.Matches(input, digitPattern);

                string name = String.Concat(nameMatch);
                var sumKm = distanceMatch.Select(x => int.Parse(x.Value)).Sum();

                if (participans.Contains(name))
                {
                    if (participansAndDistance.ContainsKey(name))
                    {
                        participansAndDistance[name] += sumKm;
                    }
                    else
                    {
                        participansAndDistance.Add(name, sumKm);
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = participansAndDistance.OrderByDescending(x => x.Value).Take(3).ToList();

            Console.WriteLine($"1st place: {sorted[0].Key}");
            Console.WriteLine($"2nd place: {sorted[1].Key}");
            Console.WriteLine($"3rd place: {sorted[2].Key}");

        }
    }
}
