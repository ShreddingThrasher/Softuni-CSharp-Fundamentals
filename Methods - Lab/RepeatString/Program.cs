using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string repeatedString = RepeatString(input, n);

            Console.WriteLine(repeatedString);
        }

        static string RepeatString(string str, int n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
