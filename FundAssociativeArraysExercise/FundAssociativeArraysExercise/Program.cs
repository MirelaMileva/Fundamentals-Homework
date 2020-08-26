using System;
using System.Collections.Generic;

namespace FundAssociativeArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charSymbols = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol == ' ')
                {
                    continue;
                }

                if (charSymbols.ContainsKey(symbol))
                {
                    charSymbols[symbol]++;
                }
                else
                {
                    charSymbols.Add(symbol, 1);
                }
            }

            foreach (var pair in charSymbols)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
            
        }
    }
}
