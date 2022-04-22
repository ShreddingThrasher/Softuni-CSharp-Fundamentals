using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] field = new int[size];

            for (int i = 0; i < indexes.Length; i++)
            {
                if(indexes[i] < 0  || indexes[i] >= field.Length)
                {
                    continue;
                }

                field[indexes[i]] = 1;
            }

            string[] input = Console.ReadLine().Split(' ');

            while(input[0] != "end")
            {
                int index = int.Parse(input[0]);
                string direction = input[1];
                int flyLength = int.Parse(input[2]);

                if(index < 0 || index >= field.Length || field[index] != 1)
                {
                    input = Console.ReadLine().Split(' ');
                    continue;
                }

                field[index] = 0;

                if(direction == "right")
                {
                    while(index + flyLength >= 0 && index + flyLength < field.Length)
                    {
                        if(field[index + flyLength] == 0)
                        {
                            field[index + flyLength] = 1;
                            break;
                        }
                        else
                        {
                            index += flyLength;
                        }
                    }
                }
                else if(direction == "left")
                {
                    while(index - flyLength >= 0 && index - flyLength < field.Length)
                    {
                        if(field[index - flyLength] == 0)
                        {
                            field[index - flyLength] = 1;
                            break;
                        }
                        else
                        {
                            index -= flyLength;
                        }
                    }
                }

                input = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(' ', field));
        }
    }
}
