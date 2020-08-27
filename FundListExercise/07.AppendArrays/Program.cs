using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> resultArrays = new List<string>();
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
          
            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] items = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < items.Length; j++)
                {
                    resultArrays.Add(items[j]);
                }
            }
            Console.WriteLine(string.Join(" ", resultArrays));
        }
    }
}
