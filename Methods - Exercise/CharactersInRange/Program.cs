using System;
using System.Collections.Generic;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());

            List<char> result = CharactersInRange(c1, c2);

            Console.WriteLine(string.Join(' ', result));
        }

        static List<char> CharactersInRange(char c1, char c2)
        {
            List<char> charsInRange = new List<char>();

            int start = (int)c1 < (int)c2 ? (int)c1 : (int)c2;
            int end = (int)c2 > (int)c1 ? (int)c2 : (int)c1;

            for (int i = start + 1; i < end; i++)
            {
                charsInRange.Add((char)i);
            }

            return charsInRange;
        }
    }
}
