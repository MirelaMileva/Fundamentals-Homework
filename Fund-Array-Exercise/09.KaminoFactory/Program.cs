using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] bestArr = new int[num];
            int bestLenght = 0;
            int bestIndex = 0;
            int bestSum = 0;
            int sample = 0;
            int bestSample = 1;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }

                int[] array = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sample++;
                int currLength = 0;
                int length = 1;
                int currIndex = 0;
                int currSum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        continue;
                    }

                    for (int index = i + 1; index < array.Length; index++)
                    {
                        if (array[index] == 1)
                        {
                            length++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (length > currLength)
                    {
                        currLength = length;
                        currIndex = i;
                        currSum = array.Sum();
                        
                    }

                }
                if (currLength > bestLenght || currLength == bestLenght && (bestIndex > currIndex) || bestArr.Sum() < currSum)
                {
                    bestLenght = currLength;
                    bestIndex = currIndex;
                    bestArr = array;
                    bestSum = currSum;
                    bestSample = sample;
                }
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(' ', bestArr)}");

        }
    }
}
