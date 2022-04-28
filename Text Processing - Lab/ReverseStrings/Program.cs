using System;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string result = "";

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    result += input[i];
                }

                Console.WriteLine($"{input} = {result}");
            }
        }
    }
}
