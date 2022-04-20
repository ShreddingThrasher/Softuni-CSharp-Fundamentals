using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";

            for (int i = 0; i < 3; i++)
            {
                result += Console.ReadLine();
            }

            Console.WriteLine(result);
        }
    }
}
