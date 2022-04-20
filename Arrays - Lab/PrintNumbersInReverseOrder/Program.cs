using System;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{inputArray[i]} ");
            }
        }
    }
}
