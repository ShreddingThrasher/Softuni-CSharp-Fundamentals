using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ').ToList();

            string input;

            while((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split(' ');

                if(command[0] == "merge")
                {
                    int start = Math.Max(0, int.Parse(command[1]));
                    int end = Math.Min(data.Count - 1, int.Parse(command[2]));
                    StringBuilder merged = new StringBuilder();

                    if(start < 0 || start >= data.Count || end < 0 || end >= data.Count)
                    {
                        continue;
                    }

                    for (int i = start; i <= end; i++)
                    {
                        merged.Append(data[start]);
                        data.RemoveAt(start);
                    }

                    data.Insert(start, merged.ToString());
                }
                else
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    string toDivide = data[index];
                    int length = toDivide.Length / partitions;

                    List<string> divided = new List<string>();
                    int start = 0;

                    for (int i = 0; i < partitions; i++)
                    {
                        if(i != partitions - 1)
                        {
                            divided.Add(toDivide.Substring(start, length));
                            start += length;
                        }
                        else
                        {
                            divided.Add(toDivide.Substring(start, toDivide.Length - start));
                        }
                    }

                    data.RemoveAt(index);
                    data.InsertRange(index, divided);

                }
            }

            Console.WriteLine(string.Join(' ', data));
        }
    }
}
