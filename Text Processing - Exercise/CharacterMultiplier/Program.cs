using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string str1 = input[0];
            string str2 = input[1];
            int sum = 0;

            int i = 0;

            while(i < str1.Length && i < str2.Length)
            {
                sum += (int)str1[i] * (int)str2[i];

                i++;

                if(i >= str1.Length && i < str2.Length)
                {
                    for (int j = i; j < str2.Length; j++)
                    {
                        sum += (int)str2[j];
                    }
                }

                if (i >= str2.Length && i < str1.Length)
                {
                    for (int j = i; j < str1.Length; j++)
                    {
                        sum += (int)str1[j];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
