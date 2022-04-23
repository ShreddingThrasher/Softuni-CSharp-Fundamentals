using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input;

            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ');

                switch (command[0])
                {
                    case "Add":
                        int n = int.Parse(command[1]);
                        numbers.Add(n);
                        break;
                    case "Remove":
                        int toRemove = int.Parse(command[1]);
                        numbers.Remove(toRemove);
                        break;
                    case "RemoveAt":
                        int removeIndex = int.Parse(command[1]);
                        numbers.RemoveAt(removeIndex);
                        break;
                    case "Insert":
                        int toInsert = int.Parse(command[1]);
                        int insertIndex = int.Parse(command[2]);
                        numbers.Insert(insertIndex, toInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
