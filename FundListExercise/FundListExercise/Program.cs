using System;
using System.Collections.Generic;
using System.Linq;

namespace FundListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPeopleCapacityWagon = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    int passengers = int.Parse(command[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(command[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxPeopleCapacityWagon)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
