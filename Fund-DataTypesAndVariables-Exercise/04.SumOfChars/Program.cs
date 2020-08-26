using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += (int)symbol;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
