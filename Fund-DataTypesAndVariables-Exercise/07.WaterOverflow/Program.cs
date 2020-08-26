using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sumQuantity = 0;

            for (int i = 0; i < nLines; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                sumQuantity += quantities;

                if (sumQuantity > capacity)
                {
                    sumQuantity -= quantities;
                    Console.WriteLine("Insufficient capacity!");
                }
                {
                    continue;
                }

            }
            Console.WriteLine(sumQuantity);
        }
    }
}
