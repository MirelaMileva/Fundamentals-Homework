using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            CharactersInRange(first, second);
        }

        static void CharactersInRange(char first, char second)
        {
            int firstChar = Math.Min(first, second);
            int secondChar = Math.Max(first, second);
            
            for (int i = firstChar + 1; i < secondChar; i++)
            {
                char result = (char)i;
                Console.Write(result + " ");
            }

        }

    }
}
