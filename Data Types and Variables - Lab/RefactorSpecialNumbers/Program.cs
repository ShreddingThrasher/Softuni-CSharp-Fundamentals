using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int current = i;
                int sum = 0;

                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", current, isSpecial);
                i = current;
            }
        }
    }
}
