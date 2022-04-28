using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendary = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            legendary.Add("shards", 0);
            legendary.Add("motes", 0);
            legendary.Add("fragments", 0);

            while (!legendary.Any(x => x.Value >= 250))
            {
                string input = Console.ReadLine().ToLower();
                string[] inputData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < inputData.Length; i += 2)
                {
                    int quantity = int.Parse(inputData[i]);
                    string material = inputData[i + 1];

                    switch (material)
                    {
                        case "motes":
                        case "shards":
                        case "fragments":
                            legendary[material] += quantity;
                            break;
                        default:
                            if (!junk.ContainsKey(material))
                            {
                                junk.Add(material, 0);
                            }
                            junk[material] += quantity;
                            break;
                    }

                    if (legendary.Any(x => x.Value >= 250))
                    {
                        break;
                    }
                }
            }

            string legendaryItem = "";

            if (legendary["shards"] >= 250)
            {
                legendaryItem = "Shadowmourne";
                legendary["shards"] -= 250;
            }
            else if (legendary["motes"] >= 250)
            {
                legendaryItem = "Dragonwrath";
                legendary["motes"] -= 250;
            }
            else
            {
                legendaryItem = "Valanyr";
                legendary["fragments"] -= 250;
            }

            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (var item in legendary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
