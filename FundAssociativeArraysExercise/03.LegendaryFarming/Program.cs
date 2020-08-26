using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> collectedItems = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            collectedItems.Add("shards", 0);
            collectedItems.Add("fragments", 0);
            collectedItems.Add("motes", 0);
            bool isCollected = false;

            while (!isCollected)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < tokens.Length; i += 2)
                {
                    int quantity = int.Parse(tokens[i]);
                    string name = tokens[i + 1].ToLower();

                    if (collectedItems.ContainsKey(name))
                    {
                        collectedItems[name] += quantity;

                        if (collectedItems[name] >= 250)
                        {
                            isCollected = true;
                            string legendaryItem = FindLegendaryItem(name);

                            Console.WriteLine($"{legendaryItem} obtained!");

                            collectedItems[name] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(name))
                        {
                            junk[name] = 0;
                        }

                        junk[name] += quantity;
                    }

                }

            }

            collectedItems = collectedItems
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(i => i.Key.ToLower(), c => c.Value);

            junk = junk.OrderBy(j => j.Key.ToLower()).ToDictionary(j => j.Key.ToLower(), t => t.Value);

            foreach (var item in collectedItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var trash in junk)
            {
                Console.WriteLine($"{trash.Key}: {trash.Value}");
            }
        }

        static string FindLegendaryItem(string name)
        {
            string legendaryItem = string.Empty;

            if (name == "shards")
            {
                legendaryItem = "Shadowmourne";
            }
            else if (name == "fragments")
            {
                legendaryItem = "Valanyr";
            }
            else if (name == "motes")
            {
                legendaryItem = "Dragonwrath";
            }

            return legendaryItem;
        }
    }
}
