using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            string input = Console.ReadLine();

            while (input.IndexOf(remove) >= 0)
            {
                input = input.Remove(input.IndexOf(remove), remove.Length);
            }

            Console.WriteLine(input);
        }
    }
}
