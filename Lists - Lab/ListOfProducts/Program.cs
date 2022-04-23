using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }

            int x = 1;

            foreach (string product in products.OrderBy(x => x))
            {
                Console.WriteLine($"{x}.{product}");
                x++;
            }
        }
    }
}
