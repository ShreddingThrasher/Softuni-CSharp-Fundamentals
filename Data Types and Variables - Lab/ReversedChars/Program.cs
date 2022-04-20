using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[3];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }

            Array.Reverse(chars);
            Console.WriteLine(string.Join(' ', chars));
        }
    }
}
