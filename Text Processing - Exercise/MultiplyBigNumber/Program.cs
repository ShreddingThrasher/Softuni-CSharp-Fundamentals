using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int remain = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int curr = int.Parse(input[i].ToString());

                int product = (curr * multiplier) + remain;

                int toAdd = product % 10;

                remain = product / 10;

                result.Insert(0, toAdd.ToString());
            }

            if (remain > 0)
            {
                result.Insert(0, remain);
            }

            Console.WriteLine(result);
        }
    }
}
