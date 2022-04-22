using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            int[] second = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] curr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if(i % 2 == 0)
                {
                    first[i] = curr[0];
                    second[i] = curr[1];
                }
                else
                {
                    first[i] = curr[1];
                    second[i] = curr[0];
                }
            }

            Console.WriteLine(string.Join(' ', first));
            Console.WriteLine(string.Join(' ', second));
        }
    }
}
