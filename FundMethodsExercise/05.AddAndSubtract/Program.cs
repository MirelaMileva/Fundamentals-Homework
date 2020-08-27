using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(first, second, third));
        }

        static int SumNumbers(int first, int second)
        {
            int sum = first + second;

            return sum;
        }

        static int Subtract(int first, int second, int third)
        {
            int result = SumNumbers(first, second) - third;

            return result;
        }
    }
}
