using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            int num = 1;

            while(counter < n)
            {
                if(num % 2 != 0)
                {
                    Console.WriteLine(num);
                    sum += num;
                    counter++;
                }

                num++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
