using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int vowels = CountVowelsInString(input);

            Console.WriteLine(vowels);
        }

        static int CountVowelsInString(string str)
        {
            string vowels = "aeiouAEIOU";

            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if(vowels.IndexOf(str[i]) >= 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
