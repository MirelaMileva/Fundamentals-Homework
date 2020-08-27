using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string commands = Console.ReadLine();

            while (commands != "3:1")
            {
                string[] commandElements = commands.Split();

                if (commandElements[0] == "merge")
                {
                    int startIndex = int.Parse(commandElements[1]);
                    int endIndex = int.Parse(commandElements[2]);

                    string concatateInput = string.Empty;

                    if (startIndex < 0 || startIndex > input.Count -1)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }

                    if ((startIndex >= 0 && startIndex <= input.Count - 1) && (endIndex >= 0 && endIndex <= input.Count - 1))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatateInput += input[i];
                        }

                        input.RemoveRange(startIndex, endIndex - startIndex + 1);
                        input.Insert(startIndex, concatateInput);
                    }

                }
                else if (commandElements[0] == "divide")
                {
                    int index = int.Parse(commandElements[1]);
                    int partitions = int.Parse(commandElements[2]);

                    if (index >= 0 && index <= input.Count - 1)
                    {
                        string word = input[index];
                        List<string> dividedWord = new List<string>();
                        int lenghtOfWord = word.Length / partitions;
                        int startIndex = 0;

                        for (int i = 0; i < partitions; i++)
                        {

                            if (i == partitions - 1)
                            {
                                dividedWord.Add(word.Substring(startIndex, word.Length - startIndex));
                            }
                            else
                            {
                                dividedWord.Add(word.Substring(startIndex, lenghtOfWord));
                                startIndex += lenghtOfWord;
                            }

                        }

                        input.RemoveAt(index);
                        input.InsertRange(index, dividedWord);
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
