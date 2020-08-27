using System;

namespace _2.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            Console.WriteLine(VowelSum(input, sum));
        }

        static int VowelSum(string input, int number)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];

                if (curr == 'A' || curr == 'a' || curr == 'e' || curr == 'E' || curr == 'I' || curr == 'i' || curr == 'O' ||
                curr == 'o' || curr == 'U' || curr == 'u')
                {
                    sum += 1;
                }
            }

            return sum;

        }
    }
}
