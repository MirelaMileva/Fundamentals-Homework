using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(FindMiddleCharacters(input));
        }

        static string FindMiddleCharacters(string input) //a S t r i n g
        {
            string result = "";
            if (input.Length % 2 == 0)
            {
                result = (input.Substring((input.Length / 2) - 1, 2));
            }
            else
            {
                result = (input.Substring((input.Length - 1) / 2, 1));
            }

            return result;
        }
    }
}
