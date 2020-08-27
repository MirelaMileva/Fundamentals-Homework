using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (!(firstPlayerCards.Count <= 0) || !(secondPlayerCards.Count <= 0))
            {
                if (firstPlayerCards[0] > secondPlayerCards[0])
                {
                    firstPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.Add(secondPlayerCards[0]);
                }

                if (firstPlayerCards[0] < secondPlayerCards[0])
                {
                    secondPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.Add(firstPlayerCards[0]);

                }

                firstPlayerCards.Remove(firstPlayerCards[0]);
                secondPlayerCards.Remove(secondPlayerCards[0]);

                //if (firstPlayerCards[0] == secondPlayerCards[0])
                //{
                //    firstPlayerCards.Remove(firstPlayerCards[0]);
                //    secondPlayerCards.Remove(secondPlayerCards[0]);
                //    continue;
                //}

                if (secondPlayerCards.Count == 0)
                {
                    break;
                }


                if (firstPlayerCards.Count == 0)
                {
                    break;
                }
            }

            if (firstPlayerCards.Count > secondPlayerCards.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }

        }
    }
}
