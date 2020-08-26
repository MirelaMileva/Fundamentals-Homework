using System;

namespace Fund_Array_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] train = new int[count];
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }

            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
