using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if(i == 0)
                {
                    result.Append(input[i]);
                    continue;
                }

                if(input[i] != input[i - 1])
                {
                    result.Append(input[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
