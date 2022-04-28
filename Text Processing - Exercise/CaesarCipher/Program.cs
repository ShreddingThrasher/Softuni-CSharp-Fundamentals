using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder encrypted = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int shiftedValue = (int)input[i] + 3;

                encrypted.Append((char)shiftedValue);
            }

            Console.WriteLine(encrypted);
        }
    }
}
