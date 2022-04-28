using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexName = new Regex(@"([A-Z]|[a-z])");
            Regex regexKm = new Regex(@"[0-9]");

            Dictionary<string, int> competitors = new Dictionary<string, int>();

            foreach (string s in Console.ReadLine().Split(", "))
            {
                competitors.Add(s, 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = string.Join("", regexName.Matches(input));
                var km = regexKm.Matches(input);
                int points = 0;

                foreach (var item in km)
                {
                    points += int.Parse(item.ToString());
                }

                if (competitors.ContainsKey(name))
                {
                    competitors[name] += points;
                }

                input = Console.ReadLine();
            }

            var topPlayers = competitors.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, y => y.Value);

            int x = 0;

            foreach (var c in topPlayers)
            {
                if (x == 0)
                {
                    Console.WriteLine($"1st place: {c.Key}");
                }
                else if (x == 1)
                {
                    Console.WriteLine($"2nd place: {c.Key}");
                }
                else if (x == 2)
                {
                    Console.WriteLine($"3rd place: {c.Key}");
                }
                else
                {
                    break;
                }

                x++;
            }
        }
    }
}
