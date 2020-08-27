using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] operations = input.Split();

                if (operations[0] == "Add")
                {
                    int number = int.Parse(operations[1]);

                    numbers.Add(number);
                }
                else if (operations[0] == "Insert")
                {
                    int element = int.Parse(operations[1]);
                    int index = int.Parse(operations[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, element);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                else if (operations[0] == "Remove")
                {
                    int index = int.Parse(operations[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    } 
                }
                else if (operations[0] == "Shift")
                {
                    int count = int.Parse(operations[2]);
                    if (operations[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = numbers[0];
                            numbers.Add(firstNum);
                            numbers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            numbers.Insert(0, lastNum);
                            numbers.RemoveAt(numbers.Count -1);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
