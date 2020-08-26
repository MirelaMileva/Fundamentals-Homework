using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            BigInteger bestValue = 0;
            BigInteger bestSnowballSnow = 0;
            BigInteger bestSnowballTime = 0;
            BigInteger bestSnowballQuality = 0;

            for (int i = 0; i < num; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = int.Parse(Console.ReadLine());
                BigInteger snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), (int)snowballQuality);

                if (snowballValue > bestValue)
                {
                    bestValue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestValue} ({bestSnowballQuality})");
        }
    }
}
