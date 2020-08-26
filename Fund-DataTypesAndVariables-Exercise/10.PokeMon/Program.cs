using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            double pokePowerNOriginal = pokePowerN / 2.0;
            int distanceTargetM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int countPokes = 0;

            while (pokePowerN >= distanceTargetM)
            {
                pokePowerN -= distanceTargetM;
                countPokes++;
                if (pokePowerN == pokePowerNOriginal)
                {
                    if (exhaustionFactorY != 0)
                    {
                        pokePowerN /= exhaustionFactorY;
                    }
                }
                
            }

            Console.WriteLine(pokePowerN);
            Console.WriteLine(countPokes);
        }
    }
}
