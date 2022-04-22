using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintOrderInfo(product, quantity);
        }

        static void PrintOrderInfo(string product, int quantity)
        {
            double total = 0;

            switch (product)
            {
                case "coffee":
                    total = quantity * 1.50;
                    break;
                case "water":
                    total = quantity * 1.00;
                    break;
                case "coke":
                    total = quantity * 1.40;
                    break;
                case "snacks":
                    total = quantity * 2.00;
                    break;
            }

            Console.WriteLine($"{total:F2}");
        }
    }
}
