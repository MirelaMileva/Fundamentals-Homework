using System;
using System.Linq;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] tokens = input.Split(">");

            string result = tokens[0];
            int remeiningPower = 0;

            for (int i = 1; i < tokens.Length; i++)
            {
                result += ">";

                string current = tokens[i];
                char currentDigit = current[0];

                int power = int.Parse(currentDigit.ToString()) + remeiningPower;

                if (power > current.Length)
                {
                    remeiningPower = power - current.Length;
                }
                else
                {
                    result += tokens[i].Substring(power);
                }
            }

            Console.WriteLine(result);
        }
    }
}
