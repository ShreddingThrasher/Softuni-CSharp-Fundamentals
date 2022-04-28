using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string product = command[0];
                double price = double.Parse(command[1]);
                int quantity = int.Parse(command[2]);

                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, new List<double>());
                    orders[product].Add(0);
                    orders[product].Add(0);
                }

                orders[product][0] = price;
                orders[product][1] += quantity;
            }

            foreach (var item in orders)
            {
                double price = item.Value[0];
                double quantity = item.Value[1];
                string product = item.Key;

                Console.WriteLine($"{product} -> {quantity * price:F2}");
            }
        }
    }
}
