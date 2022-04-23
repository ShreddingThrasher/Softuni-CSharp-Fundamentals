using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input;
            bool changed = false;

            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ');

                switch (command[0])
                {
                    case "Add":
                        int n = int.Parse(command[1]);
                        numbers.Add(n);
                        changed = true;
                        break;
                    case "Remove":
                        int toRemove = int.Parse(command[1]);
                        numbers.Remove(toRemove);
                        changed = true;
                        break;
                    case "RemoveAt":
                        int removeIndex = int.Parse(command[1]);
                        numbers.RemoveAt(removeIndex);
                        changed = true;
                        break;
                    case "Insert":
                        int toInsert = int.Parse(command[1]);
                        int insertIndex = int.Parse(command[2]);
                        numbers.Insert(insertIndex, toInsert);
                        changed = true;
                        break;
                    case "Contains":
                        int number = int.Parse(command[1]);
                        string contains = numbers.Contains(number) ? "Yes" : "No such number";
                        Console.WriteLine(contains);
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(' ', numbers.Where(x => x % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(' ', numbers.Where(x => x % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = command[1];
                        int criteria = int.Parse(command[2]);
                        Filter(numbers, condition, criteria);
                        break;
                }
            }

            if (changed)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }

        static void Filter(List<int> numbers, string condition, int criteria)
        {
            switch (condition)
            {
                case "<":
                    Console.WriteLine(string.Join(' ', numbers.Where(x => x < criteria)));
                    break;
                case ">":
                    Console.WriteLine(string.Join(' ', numbers.Where(x => x > criteria)));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(' ', numbers.Where(x => x >= criteria)));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(' ', numbers.Where(x => x <= criteria)));
                    break;
            }
        }
    }
}
