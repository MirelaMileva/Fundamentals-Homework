using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                string temp = arr[0];

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = temp;

            }
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
