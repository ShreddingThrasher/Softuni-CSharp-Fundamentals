using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            List<int> result = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int[] curr = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < curr.Length; j++)
                {
                    result.Add(curr[j]);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
