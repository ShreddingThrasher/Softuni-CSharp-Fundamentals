using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int limit = int.Parse(Console.ReadLine());

            string input;

            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ');

                if(command.Length == 1)
                {
                    int passengers = int.Parse(command[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if(wagons[i] + passengers <= limit)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                else
                {
                    int passengers = int.Parse(command[1]);
                    wagons.Add(passengers);
                }
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
