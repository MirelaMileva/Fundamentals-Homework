using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^0-9+\-\/.*]";
            Regex healthRegex = new Regex(healthPattern);

            string digitPattern = @"-?\d+\.?\d*";
            Regex digitRegex = new Regex(digitPattern);

            string operaterPattern = @"[*\/]";
            Regex operatorRegex = new Regex(operaterPattern);

            string[] demonsNames = Regex
                .Split(Console.ReadLine(), @"\s*,\s*")
                .OrderBy(x => x).ToArray();

            for (int i = 0; i < demonsNames.Length; i++)
            {
                string currentDemonName = demonsNames[i];

                int currentHealth = 0;

                MatchCollection healthSymbols = healthRegex.Matches(currentDemonName);

                foreach (Match symbol in healthSymbols)
                {
                    currentHealth += char.Parse(symbol.Value);
                }

                MatchCollection digitMatch = digitRegex.Matches(currentDemonName);
                double baseDamage = 0;

                foreach (Match number in digitMatch)
                {
                    baseDamage += double.Parse(number.Value);
                }

                MatchCollection operatorMatch = operatorRegex.Matches(currentDemonName);

                foreach (Match operatorr in operatorMatch)
                {
                    string currOperator = operatorr.Value;

                    if (currOperator == "*")
                    {
                        baseDamage *= 2;
                    }
                    else
                    {
                        baseDamage /= 2;
                    }
                }

                Console.WriteLine($"{currentDemonName} - {currentHealth} health, {baseDamage:f2} damage");
            }
        }
    }
}
