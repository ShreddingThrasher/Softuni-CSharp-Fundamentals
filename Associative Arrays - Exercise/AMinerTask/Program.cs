using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mining = new Dictionary<string, int>();

            string input;

            while((input = Console.ReadLine()) != "stop")
            {
                string material = input;
                int quantity = int.Parse(Console.ReadLine());

                if (!mining.ContainsKey(material))
                {
                    mining.Add(material, 0);
                }

                mining[material] += quantity;
            }

            foreach (var item in mining)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
