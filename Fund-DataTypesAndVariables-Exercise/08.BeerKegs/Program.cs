using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int nBeerKegs = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < nBeerKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = (Math.PI * Math.Pow(radius, 2) * height);

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
