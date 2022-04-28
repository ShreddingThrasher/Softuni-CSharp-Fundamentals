using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@">{2}(?<name>[A-z]+)<<(?<price>[0-9]+\.*[0-9]*)!(?<qty>[0-9]+)");

            List<string> items = new List<string>();
            double totalPrice = 0.0;

            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                Match m = regex.Match(input);

                if (m.Success)
                {
                    items.Add(m.Groups["name"].Value);
                    double price = double.Parse(m.Groups["price"].Value);
                    int qty = int.Parse(m.Groups["qty"].Value);

                    totalPrice += price * qty;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (string s in items)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
