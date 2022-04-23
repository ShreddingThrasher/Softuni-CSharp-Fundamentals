using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();
            int count = first.Count + second.Count;


            for (int i = 0; i < count; i++)
            {
                if (first.Count != 0)
                {
                    result.Add(first[0]);
                    first.RemoveAt(0);
                }
                if (second.Count != 0)
                {
                    result.Add(second[0]);
                    second.RemoveAt(0);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
