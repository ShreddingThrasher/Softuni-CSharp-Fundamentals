using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int mined = 0;
            int days = 0;

            while (startingYield >= 100)
            {
                days++;
                mined += startingYield;

                if (mined >= 26)
                {
                    mined -= 26;
                }

                startingYield -= 10;
            }

            if (mined >= 26)
            {
                mined -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(mined);
        }
    }
}
