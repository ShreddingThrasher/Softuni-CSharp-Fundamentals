using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ');

                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Insert":
                        int insertIndex = int.Parse(command[2]);
                        int insertItem = int.Parse(command[1]);

                        if (insertIndex >= numbers.Count || insertIndex < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }

                        numbers.Insert(insertIndex, insertItem);

                        break;
                    case "Remove":

                        int index = int.Parse(command[1]);

                        if (index >= numbers.Count || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }

                        numbers.RemoveAt(index);

                        break;
                    case "Shift":

                        int shifts = int.Parse(command[2]);

                        if (command[1] == "left")
                        {
                            for (int i = 0; i < shifts; i++)
                            {
                                int firstNum = numbers[0];
                                numbers.Add(firstNum);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < shifts; i++)
                            {
                                int lastNum = numbers[numbers.Count - 1];
                                numbers.Insert(0, lastNum);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
