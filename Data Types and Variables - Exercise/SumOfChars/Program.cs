using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            string input = "";

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                sum += (int)input[0];
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
