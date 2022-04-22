using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxCounter = 0;
            int currentCounter = 0;
            int number = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    currentCounter++;
                    if (currentCounter > maxCounter)
                    {
                        maxCounter = currentCounter;
                        number = input[i];
                    }
                }
                else
                {
                    currentCounter = 0;
                }
            }
            for (int i = 0; i <= maxCounter; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
