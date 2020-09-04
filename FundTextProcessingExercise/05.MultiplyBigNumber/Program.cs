using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstNum = Console.ReadLine().ToCharArray();
            int multiplier = int.Parse(Console.ReadLine());
            int reminder = 0;

            if (multiplier == 0)
            {
                Console.WriteLine('0');
                return;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                char currentChar = firstNum[i];
                int currentNum = int.Parse(currentChar.ToString());

                int sum = (currentNum * multiplier) + reminder;
                sb.Append(sum % 10);
                reminder = sum / 10;
            }

            if (reminder != 0)
            {
                sb.Append(reminder);
            }

            List<char> resultArr = sb.ToString().Reverse().ToList();
            RemoveZiroes(resultArr);

            Console.WriteLine(string.Join("", resultArr));

        }

        private static void RemoveZiroes(List<char> resultArr)
        {
            if (resultArr[0] == '0')
            {
                int zeroCount = 0;

                for (int i = 1; i < resultArr.Count; i++)
                {
                    if (resultArr[i] != '0')
                    {
                        zeroCount = i;
                    }
                }

                for (int i = 0; i < zeroCount; i++)
                {
                    resultArr.RemoveAt(0);
                }
            }
        }
    }
}
