using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} -> {isSpecial(i.ToString())}");
            }
        }

        static bool isSpecial(string number)
        {
            int sum = 0;

            for (int j = 0; j < number.Length; j++)
            {
                sum += int.Parse(number[j].ToString());
            }

            return sum == 5 || sum == 7 || sum == 11;
        }
    }
}
