using System;
using System.Numerics;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger bestSnowball = int.MinValue;
            BigInteger currentBall = 0;


            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                currentBall = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (currentBall > bestSnowball)
                {
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                    bestSnowball = currentBall;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {bestSnowball} ({bestQuality})");
        }
    }
}
