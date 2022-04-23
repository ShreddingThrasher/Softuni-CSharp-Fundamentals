using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            while (input.Any())
            {
                if(input.Count == 1)
                {
                    result.Add(input[0]);
                    break;
                }

                result.Add(input[0] + input[input.Count - 1]);
                input.RemoveAt(0);
                input.RemoveAt(input.Count - 1);
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
