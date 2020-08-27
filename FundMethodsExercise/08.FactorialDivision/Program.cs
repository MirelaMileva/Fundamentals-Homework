using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            decimal result = FactorialSum(first) / FactorialSum(second);
            Console.WriteLine($"{result:f2}");

        }

        static decimal FactorialSum(int number)
        {
            decimal sum = 1;

            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }

            return sum;
        }

    }
}
