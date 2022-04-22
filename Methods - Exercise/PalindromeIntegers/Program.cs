using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while(input != "END")
            {
                Console.WriteLine(IsPalindrome(input));

                input = Console.ReadLine();
            }
        }
        
        static bool IsPalindrome(string str)
        {
            string reversed = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                reversed += str[i];
            }

            if(str == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
