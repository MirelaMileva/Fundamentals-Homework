using System;
using System.Collections.Generic;
using System.Reflection;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerTask = new Dictionary<string, int>();

            while (true)
            { 
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (minerTask.ContainsKey(resource))
                {
                    minerTask[resource] += quantity;
                }
                else
                {
                    minerTask.Add(resource, quantity);
                }
            }

            foreach (var pair in minerTask)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
