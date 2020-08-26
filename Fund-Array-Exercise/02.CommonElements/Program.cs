using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            string result = "";

            foreach(string word1 in arr2)
            {
                foreach (string word2 in arr1)
                {
                    if (word1 == word2)
                    {
                        result += word1 + " ";
                    }
                }
                
            }

            Console.WriteLine(result);
        }
    }
}
