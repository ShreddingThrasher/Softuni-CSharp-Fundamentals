﻿using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                if(n % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                    n = int.Parse(Console.ReadLine());
                    continue;
                }

                Console.WriteLine($"The number is: {Math.Abs(n)}");
                break;
            }
        }
    }
}
