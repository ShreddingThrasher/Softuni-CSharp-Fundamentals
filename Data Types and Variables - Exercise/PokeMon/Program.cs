using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int startingPower = pokePower;

            int poked = 0;

            while (pokePower >= distance)
            {
                poked++;
                pokePower -= distance;

                if (pokePower == startingPower * 0.5 && exhaustion != 0)
                {
                    pokePower /= exhaustion;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(poked);
        }
    }
}
