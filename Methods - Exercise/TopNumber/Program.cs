using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            TopNumbersInRange(int.Parse(Console.ReadLine()));
        }

        static void TopNumbersInRange(int end)
        {

            for (int i = 0; i <= end; i++)
            {
                string curr = i.ToString();
                int currSum = 0;

                for (int j = 0; j < curr.Length; j++)
                {
                    currSum += int.Parse(curr[j].ToString());
                }

                if (currSum % 8 == 0)
                {
                    for (int k = 0; k < curr.Length; k++)
                    {
                        if (curr[k] % 2 != 0)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
            }
        }
    }
}
