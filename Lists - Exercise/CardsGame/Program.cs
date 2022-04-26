using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while(firstHand.Any() && secondHand.Any())
            {
                int first = firstHand[0];
                int second = secondHand[0];
                firstHand.RemoveAt(0);
                secondHand.RemoveAt(0);

                if(first > second)
                {
                    firstHand.Add(first);
                    firstHand.Add(second);
                }
                else if(second > first)
                {
                    secondHand.Add(second);
                    secondHand.Add(first);
                }
            }

            if (firstHand.Any())
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
        }
    }
}
