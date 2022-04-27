using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                string toLowerCase = input[i].ToLower();

                if (words.ContainsKey(toLowerCase))
                {
                    words[toLowerCase]++;
                }
                else
                {
                    words.Add(toLowerCase, 1);
                }
            }

            Console.WriteLine(string.Join(' ', words.Where(x => x.Value % 2 != 0).Select(x => x.Key)));
        }
    }
}
