using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = CalculateSum(input[0], input[1]);
            Console.WriteLine(sum);
        }

        static int CalculateSum(string first, string second)
        {
            int sum = 0;
            int minLength = Math.Min(first.Length, second.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += first[i] * second[i];

            }

            string longest = first;

            if (longest.Length < second.Length)
            {
                longest = second;
            }

            for (int i = minLength; i < longest.Length; i++)
            {
                sum += longest[i];
            }

            return sum;
        }
    }
}
