using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //using LINQ
            //List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //List<int> result = input.Where(x => x >= 0).Reverse().ToList();

            //if(result.Count > 0)
            //{
            //    Console.WriteLine(string.Join(' ', result));
            //}
            //else
            //{
            //    Console.WriteLine("empty");
            //}

            //without LINQ
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            input.RemoveAll(x => x < 0);
            input.Reverse();

            if(input.Count > 0)
            {
                Console.WriteLine(string.Join(' ', input));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
