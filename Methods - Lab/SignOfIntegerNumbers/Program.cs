using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number {n} is {CheckNumber(n)}.");
        }

        static string CheckNumber(int n)
        {
            if(n < 0)
            {
                return "negative";
            }
            else if(n > 0)
            {
                return "positive";
            }
            else
            {
                return "zero";
            }
        }
    }
}
