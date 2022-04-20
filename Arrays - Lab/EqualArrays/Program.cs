using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            int firstDifference = int.MinValue;

            for (int i = 0; i < firstArray.Length; i++)
            {
                sum += firstArray[i];

                if (firstArray[i] != secondArray[i])
                {
                    if (firstDifference == int.MinValue)
                    {
                        firstDifference = i;
                    }
                }
            }

            if (firstDifference != int.MinValue)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {firstDifference} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
