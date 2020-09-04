using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                double tempSum = 0;
                string currentInput = input[i];
                char firstLetter = currentInput[0];
                char lastLetter = currentInput[currentInput.Length - 1];
                double number = CharNumberParsed(currentInput);
                tempSum += number;

                int firstLetterPosition = LetterPositonInAlphabet(firstLetter);
                int lastLetterPosition = LetterPositonInAlphabet(lastLetter);

                if (Char.IsUpper(firstLetter))
                {
                    tempSum /= firstLetterPosition;
                }
                else
                {
                    tempSum *= firstLetterPosition;
                }

                if (Char.IsUpper(lastLetter))
                {
                    tempSum -= lastLetterPosition;
                }
                else
                {
                    tempSum += lastLetterPosition;
                }

                sum += tempSum;

            }

            Console.WriteLine($"{sum:f2}");
        }
        static int LetterPositonInAlphabet(char letter)
        {
            int position = -1;

            if (Char.IsLetter(letter))
            {
                if (Char.IsUpper(letter))
                {
                    position = letter - 64;
                }
                else
                {
                    position = letter - 96;
                }
            }

            return position;
        }
        static double CharNumberParsed(string currentInput)
        {
            char[] numberAsChar = currentInput.Skip(1).Take(currentInput.Length - 2).ToArray();
            string numberAsString = string.Join("", numberAsChar);
            double number = double.Parse(numberAsString);

            return number;
        }
    }
}
