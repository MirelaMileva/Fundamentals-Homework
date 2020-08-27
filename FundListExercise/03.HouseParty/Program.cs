using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandNum = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < commandNum; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string name = commands[0];

                if (commands[2] == "going!")
                {
                    
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);   
                    }
                }
                else if (commands[2] == "not")
                {

                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }

                
            }

            Console.WriteLine(string.Join("\n",guestList));
        }
    }
}
