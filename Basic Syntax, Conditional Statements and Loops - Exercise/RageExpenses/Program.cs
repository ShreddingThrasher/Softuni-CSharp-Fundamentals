using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double rageExpenses = 0;

            int brokenHeadsets = 0;
            int brokenMouses = 0;
            int brokenKeyboards = 0;
            int brokenDisplays = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    brokenHeadsets++;
                }
                if (i % 3 == 0)
                {
                    brokenMouses++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    brokenKeyboards++;
                }
            }

            brokenDisplays = brokenKeyboards / 2;

            rageExpenses = (brokenHeadsets * headsetPrice) + (brokenMouses * mousePrice)
                         + (brokenKeyboards * keyboardPrice) + (brokenDisplays * displayPrice);

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
