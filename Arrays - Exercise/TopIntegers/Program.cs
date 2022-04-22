using System;
using System.Collections.Generic;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < input.Length; i++)
            {
                bool bigger = true;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] <= input[j])
                    {
                        bigger = false;
                    }
                }
                if (bigger)
                {
                    Console.Write($"{input[i]} ");
                }
            }
        }
    }
}
