using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<day>[0-9]{2})(?<sep>[-.\/])(?<month>[A-Z][a-z]{2})\k<sep>(?<year>[0-9]{4})");

            string input = Console.ReadLine();

            MatchCollection dates = regex.Matches(input);

            foreach (Match m in dates)
            {
                Console.WriteLine($"Day: {m.Groups["day"].Value}, Month: {m.Groups["month"].Value}, Year: {m.Groups["year"].Value}");
            }
        }
    }
}
