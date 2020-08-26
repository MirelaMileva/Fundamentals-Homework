using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> registeredUser = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                string userName = tokens[1];

                if (command == "register")
                {
                    string plateNumber = tokens[2];

                    if (!registeredUser.ContainsKey(userName))
                    {
                        registeredUser.Add(userName, plateNumber);
                        Console.WriteLine($"{userName} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registeredUser[userName]}");
                    }
                }
                else
                {
                    if (!registeredUser.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        registeredUser.Remove(userName);
                    }
                }
            }

            foreach (var user in registeredUser)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
            
        }
    }
}
