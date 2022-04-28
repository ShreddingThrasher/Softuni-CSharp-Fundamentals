using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    continue;
                }

                if (!charCount.ContainsKey(input[i]))
                {
                    charCount.Add(input[i], 0);
                }

                charCount[input[i]]++;
            }

            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
