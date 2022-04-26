using System;
using System.Linq;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> partyPeople = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                if(input.Length == 3)
                {
                    if (!partyPeople.Contains(input[0]))
                    {
                        partyPeople.Add(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                }
                else
                {
                    if (partyPeople.Contains(input[0]))
                    {
                        partyPeople.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join('\n', partyPeople));
        }
    }
}
