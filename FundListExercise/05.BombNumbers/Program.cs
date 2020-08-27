using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombAndPowerNum = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = bombAndPowerNum[0];
            int power = bombAndPowerNum[1];

            int bombIndex = sequenceNumbers.IndexOf(bomb);

            while (bombIndex != -1)
            {
                int leftNumbers = bombIndex - power;
                int rightNumbers = bombIndex + power;

                if (leftNumbers < 0)
                {
                    leftNumbers = 0;
                }

                if (rightNumbers > sequenceNumbers.Count -1)
                {
                    rightNumbers = sequenceNumbers.Count - 1;
                }

                sequenceNumbers.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);

                bombIndex = sequenceNumbers.IndexOf(bomb);

            }
            int sum = sequenceNumbers.Sum();

            Console.WriteLine(sum);
        }

    }
}
