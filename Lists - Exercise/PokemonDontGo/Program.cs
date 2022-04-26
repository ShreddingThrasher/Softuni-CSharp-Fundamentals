using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            while (numbers.Any())
            {
                int index = int.Parse(Console.ReadLine());
                int element = 0;

                if (index < 0)
                {
                    int last = numbers[numbers.Count - 1];

                    element = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Insert(0, last);
                }
                else if(index >= numbers.Count)
                {
                    int first = numbers[0];

                    element = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(first);
                }
                else
                {
                    element = numbers[index];
                    numbers.RemoveAt(index);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= element)
                    {
                        numbers[i] += element;
                    }
                    else
                    {
                        numbers[i] -= element;
                    }
                }

                sum += element;
            }

            Console.WriteLine(sum);
        }
    }
}
