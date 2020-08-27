using System;

namespace FundMethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSmallestNumber(first, second, third));
        }

        static int GetSmallestNumber(int first, int second, int third)
        {
            int result = 0;
            if (first <= second && first <= third)
            {
                result = first;
            }

            if (second <= first && second <= third)
            {
                result = second;
            }

            if (third < first && third < second)
            {
                result = third;
            }

            return result;
        }
    }
}
