using System;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input);

            int remainder = 0;
            bool hasRemainder = false;

            for (int i = 0; i < sb.Length; i++)
            {
                if (input[i] == '>')
                {
                    if (i == sb.Length - 1)
                    {
                        sb[sb.Length - 1] = ':';
                        break;
                    }
                    int power = int.Parse(sb[i + 1].ToString()) + remainder;
                    remainder = power;

                    for (int j = i + 1; j < i + 1 + power; j++)
                    {
                        if (j >= sb.Length)
                        {
                            break;
                        }
                        if (sb[j] == '>')
                        {
                            remainder = (i + power) - (i + 1);
                            hasRemainder = true;
                            break;
                        }
                        sb[j] = ':';

                    }

                    if (!hasRemainder)
                    {
                        remainder = 0;
                    }
                }
            }

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] != ':')
                {
                    Console.Write(sb[i]);
                }
            }
        }
    }
}
