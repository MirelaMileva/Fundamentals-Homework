using System;
using System.Linq;

namespace _09.KaminoFactorySecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestLength = 0;
            int bestIndex = 0;
            int[] arr2 = new int[n];
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

                int[] arr = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sample++;
                int length = 1;
                int currBestLength = 0;
                int currIndex = 0;
                int currSum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 0)
                    {
                        continue;
                    }
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] == arr[i + 1])
                        {
                            length++;
                        }
                        else
                        {
                            break;
                        }


                        if (length > currBestLength)
                        {
                            currBestLength = length;
                            currIndex = i;
                            currSum = arr.Sum();
                            arr2 = arr.ToArray();
                        }
                    }

                }
                if (currBestLength > bestLength || currBestLength == bestLength && currIndex > bestIndex || currSum > arr2.Sum() || bestSample > sample)
                {
                    bestLength = currBestLength;
                    bestIndex = currIndex;
                    arr2 = arr;
                    bestSum = currSum;
                    bestSample = sample;    
                }
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", arr2)}");
        }
    }
}
