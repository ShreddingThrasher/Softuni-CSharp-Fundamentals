using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex nameRegex = new Regex(@"%(?<name>[A-Z][a-z]+)%");
            Regex productRegex = new Regex(@"\<(?<product>\w+)\>");
            Regex countRegex = new Regex(@"\|(?<count>[0-9]+)\|");
            Regex priceRegex = new Regex(@"(?<price>[0-9]+\.*[0-9]*)\$");

            double totalIncome = 0.0;

            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                if (nameRegex.IsMatch(input) && productRegex.IsMatch(input) && countRegex.IsMatch(input) && priceRegex.IsMatch(input))
                {
                    string name = nameRegex.Match(input).Groups["name"].Value;
                    string product = productRegex.Match(input).Groups["product"].Value;
                    int count = int.Parse(countRegex.Match(input).Groups["count"].Value);
                    double price = double.Parse(priceRegex.Match(input).Groups["price"].Value);

                    Console.WriteLine($"{name}: {product} - {count * price:F2}");

                    totalIncome += count * price;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
