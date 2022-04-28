using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex starRegex = new Regex(@"[STAR]|[star]");
            Regex mainRegex = new Regex(@"@(?<planet>[A-Za-z]+)([^@\-!:>])*:(?<population>[0-9]+)([^@\-!:>])*!(?<type>[AD])!([^@\-!:>])*->(?<soldiers>[0-9]+)");

            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int decryptionKey = starRegex.Matches(input).Count;

                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < input.Length; j++)
                {
                    sb.Append((char)((int)input[j] - decryptionKey));
                }

                string decrypted = sb.ToString();

                if(mainRegex.IsMatch(decrypted))
                {
                    string planet = mainRegex.Match(decrypted).Groups["planet"].Value;
                    string attackType = mainRegex.Match(decrypted).Groups["type"].Value;

                    switch (attackType)
                    {
                        case "A":
                            attacked.Add(planet);
                            break;
                        case "D":
                            destroyed.Add(planet);
                            break;
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");

            foreach (string planet in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");

            foreach (string planet in destroyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
