using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < num.ToString().Length; i++)
            {
                sum += int.Parse(num.ToString()[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
