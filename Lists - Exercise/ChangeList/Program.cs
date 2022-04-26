using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
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
                    case "Delete":
                        int criteria = int.Parse(command[1]);
                        numbers.RemoveAll(x => x == criteria);
                        break;
                    case "Insert":
                        int element = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, element);
                        break;
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
