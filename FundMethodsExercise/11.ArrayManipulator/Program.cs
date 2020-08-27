using System;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || index > arr.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    Exchange(arr, index);

                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        if (MaxEven(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(MaxEven(arr));
                    }
                    else
                    {
                        if (MaxOdd(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(MaxOdd(arr));
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        if (MinEven(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MinEven(arr));
                    }
                    else
                    {
                        if (MinOdd(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(MinOdd(arr));
                    }
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);

                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        ReturnFirstEvenElements(arr, count);
                    }
                    else
                    {
                        ReturnFirstOddElements(arr, count);
                    }
                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);
                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (command[2] == "even")
                    {
                        ReturnLastEvenElements(arr, count);
                    }
                    else
                    {
                        ReturnLastOddElements(arr, count);
                    }
                }
            }

            Console.WriteLine("[" + String.Join(", ", arr) + "]");
        }

        static void Exchange (int[] array, int index)
        {
            int[] arrayOne = new int[array.Length - index - 1];
            int[] arrayTwo = new int[index + 1];

            int arrayOneCounter = 0;
            for (int i = index + 1; i < array.Length; i++)
            {
                arrayOne[arrayOneCounter] = array[i];
                arrayOneCounter++;
            }

            for (int i = 0; i < index + 1; i++)
            {
                arrayTwo[i] = array[i];
            }

            for (int i = 0; i < arrayOne.Length; i++)
            {
                array[i] = arrayOne[i];
            }

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                array[arrayOne.Length + i] = arrayTwo[i];
            }
        }

        static int MaxEven(int[] array)
        {
            int maxEvenNumber = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= maxEvenNumber)
                    {
                        maxEvenNumber = array[i];
                        index = i;
                    }
                    
                }
            }

            return index;
        }

        static int MaxOdd(int[] array)
        {
            int maxOddNumber = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxOddNumber)
                    {
                        maxOddNumber = array[i];
                        index = i;
                    }

                }
            }

            return index;
        }

        static int MinEven(int[] array)
        {
            int minEvenNumber = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= minEvenNumber)
                    {
                        minEvenNumber = array[i];
                        index = i;
                    }

                }
            }

            return index;
        }

        static int MinOdd(int[] array)
        {
            int minOddNumber = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] <= minOddNumber)
                    {
                        minOddNumber = array[i];
                        index = i;
                    }

                }
            }

            return index;
        }

        static void ReturnFirstEvenElements(int[] array, int count)
        {
            string numbers = String.Empty;
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    numbers += array[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            var elements = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", elements) + "]");
            }

        }

        static void ReturnFirstOddElements(int[] array, int count)
        {
            string numbers = String.Empty;
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    numbers += array[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            var elements = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", elements) + "]");
            }

        }

        static void ReturnLastEvenElements(int[] array, int count)
        {
            string numbers = String.Empty;
            int counter = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    numbers += array[i] + " ";
                    counter++;
                }

                if (counter == count)
                {
                    break;
                }
            }

            var elements = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse();

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", elements) + "]");
            }
        }

        static void ReturnLastOddElements(int[] array, int count)
        {
            string numbers = String.Empty;
            int counter = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                {
                    counter++;
                    numbers += array[i] + " ";
                }

                if (counter == count)
                {
                    break;
                }
            }

            var elements = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse();

            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + String.Join(", ", elements) + "]");
            }
        }
    }
}
