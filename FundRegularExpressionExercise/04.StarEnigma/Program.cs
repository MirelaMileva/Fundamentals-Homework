using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string pattern = @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attack>A|D)![^@\-!:>]*->(?<soldiers>\d+)";

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int specialNumber = SpecialLettersCount(encryptedMessage);
                string decryptedMessage = DecryptedMessage(encryptedMessage, specialNumber);

                Match match = Regex.Match(decryptedMessage, pattern);

                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;
                    string attackType = match.Groups["attack"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }

                }
            }

            PrintOutput(attackedPlanets, "Attacked");
            PrintOutput(destroyedPlanets, "Destroyed");

        }

        private static void PrintOutput(List<string> planets, string attackType)
        {
            Console.WriteLine($"{attackType} planets: {planets.Count}");
            foreach (var planet in planets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
        private static string DecryptedMessage(string encrypted, int key)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < encrypted.Length; i++)
            {
                char current = encrypted[i];
                char decrypted = (char)(current - key);

                sb.Append(decrypted);
            }

            return sb.ToString();
        }
        private static int SpecialLettersCount(string message)
        {
            char[] specialLetters = new char[] { 's', 't', 'a', 'r' };
            int specialLettersCount = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char currentCh = message[i];

                if (specialLetters.Contains(Char.ToLower(currentCh)))
                {
                    specialLettersCount++;
                }
            }

            return specialLettersCount;
        }
    }
}
