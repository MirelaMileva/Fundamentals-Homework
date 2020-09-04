using System;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                int repeated = 0;
                for (int j = i + 1; j < input.Length; j++)
                {
                    char nextCurr = input[j];
                    if (current == nextCurr)
                    {
                        repeated++;
                    }
                    else
                    {
                        break;
                    }
                }

                input = input.Remove(i + 1, repeated);
            }

            Console.WriteLine(input);
        }
    }
}
