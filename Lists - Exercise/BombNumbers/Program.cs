using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split(' ');

            int bombNumber = int.Parse(input[0]);
            int power = int.Parse(input[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == bombNumber)
                {
                    numbers[i] = 0;

                    for (int j = i; j >= i - power; j--)
                    {
                        if (j >= numbers.Count || j < 0)
                        {
                            break;
                        }

                        numbers[j] = 0;
                    }

                    for (int j = i; j <= i + power; j++)
                    {
                        if (j >= numbers.Count || j < 0)
                        {
                            break;
                        }

                        numbers[j] = 0;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
