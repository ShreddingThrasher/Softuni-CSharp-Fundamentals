using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;
            string input = Console.ReadLine();
            double productPrice = 0;

            while (input != "Start")
            {
                switch (input)
                {
                    case "0.1":
                        totalMoney += double.Parse(input);
                        break;
                    case "0.2":
                        totalMoney += double.Parse(input);
                        break;
                    case "0.5":
                        totalMoney += double.Parse(input);
                        break;
                    case "1":
                        totalMoney += double.Parse(input);
                        break;
                    case "2":
                        totalMoney += double.Parse(input);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {input}");
                        break;

                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {

                switch (input)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        input = Console.ReadLine();
                        continue;
                }


                if (totalMoney >= productPrice)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    totalMoney -= productPrice;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
