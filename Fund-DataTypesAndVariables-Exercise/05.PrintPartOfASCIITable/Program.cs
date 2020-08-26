using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCharStart = int.Parse(Console.ReadLine());
            int numCharEnd = int.Parse(Console.ReadLine());

            for (int i = numCharStart; i <= numCharEnd; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
