using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal gbp = decimal.Parse(Console.ReadLine());
            decimal usd = gbp * (decimal)1.31;

            Console.WriteLine($"{usd:F3}");
        }
    }
}
