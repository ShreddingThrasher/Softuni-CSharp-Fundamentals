using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int evenSum = input.Where(x => x % 2 == 0).Sum();
            int oddSum = input.Where(x => x % 2 != 0).Sum();

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
