using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLenght = 0;
            int lenght = 1;
            int start = 0;
            int bestResult = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i -1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                    start = i;
                }

                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    bestResult = start;
                }
            }

            for (int i = bestResult; i < bestResult + maxLenght; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
