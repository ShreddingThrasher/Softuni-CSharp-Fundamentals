using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());

            double maxVolume = double.MinValue;
            string biggestKeg = "";

            for (int i = 0; i < kegs; i++)
            {
                string kegName = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                double volume = Math.PI * (r * r) * h;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = kegName;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
