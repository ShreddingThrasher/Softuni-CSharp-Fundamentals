using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenSum = EvenSum(n);
            int oddSum = OddSum(n);
            int result = evenSum * oddSum;

            Console.WriteLine(result);
        }

        static int OddSum(int n)
        {
            int sum = 0;
            string numToString = n.ToString();

            for (int i = 0; i < numToString.Length; i++)
            {
                if (!char.IsDigit(numToString[i]))
                {
                    continue;
                }

                int curr = int.Parse(numToString[i].ToString());

                if (curr % 2 != 0)
                {
                    sum += curr;
                }
            }

            return sum;
        }

        static int EvenSum(int n)
        {
            int sum = 0;
            string numToString = n.ToString();

            for (int i = 0; i < numToString.Length; i++)
            {
                if (!char.IsDigit(numToString[i]))
                {
                    continue;
                }

                int curr = int.Parse(numToString[i].ToString());

                if(curr % 2 == 0)
                {
                    sum += curr;
                }
            }

            return sum;
        }
    }
}
