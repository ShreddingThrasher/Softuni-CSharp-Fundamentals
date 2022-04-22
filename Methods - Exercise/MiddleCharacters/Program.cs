using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MiddleCharacters(input);
        }

        static void MiddleCharacters(string str)
        {
            if (str.Length % 2 == 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(str[((str.Length / 2) - 1) + i]);
                }
            }
            else
            {
                Console.WriteLine(str[(str.Length / 2)]);
            }
        }
    }
}
