using System;
using System.IO;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());
            int[] index = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[sizeField];

            for (int i = 0; i < index.Length; i++)
            {
                int currIndex = index[i];

                if (currIndex >= 0 && currIndex < field.Length)
                {
                    field[currIndex] = 1;
                } 
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split();
                int ladyBugIndex = int.Parse(input[0]);
                string direction = input[1];
                int flyLength = int.Parse(input[2]);

                if (ladyBugIndex < 0 || ladyBugIndex > field.Length - 1 || field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = ladyBugIndex + flyLength;
                    if (landIndex > field.Length - 1)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;

                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    } 
                }
                else if (direction == "left")
                {
                    int landIndex = ladyBugIndex - flyLength;
                    if (landIndex < 0)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;

                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }

                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
