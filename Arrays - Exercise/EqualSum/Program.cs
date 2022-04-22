using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool noSuchElement = true;

            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int RightSum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (j < i)
                    {
                        leftSum += input[j];
                    }
                    else if (j > i)
                    {
                        RightSum += input[j];
                    }
                }
                if (leftSum == RightSum)
                {
                    Console.WriteLine($"{i}");
                    noSuchElement = false;
                }
            }

            if (noSuchElement)
            {
                Console.WriteLine("no");
            }
        }
    }
}
