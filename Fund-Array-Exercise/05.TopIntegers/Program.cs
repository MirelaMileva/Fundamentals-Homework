using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            string result = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                bool isTopInt = true;

                for (int index = i + 1; index < numbers.Length; index++)
                {
                    if (current <= numbers[index])
                    {
                        isTopInt = false;
                        break;
                    }
                    
                }
                if (isTopInt)
                {
                    result += current + " ";
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
