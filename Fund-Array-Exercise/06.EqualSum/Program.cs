using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = arr.Sum();

            for (int i = 0; i < arr.Length; i++)
            {
                rightSum -= arr[i];

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum += arr[i];
            }

            Console.WriteLine("no");
        }
    }
}
