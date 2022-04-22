using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(Compare(num1, num2));
                    break;
                case "char":
                    char c1 = char.Parse(Console.ReadLine());
                    char c2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(Compare(c1, c2));
                    break;
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Console.WriteLine(Compare(str1, str2));
                    break;
            }
        }

        static int Compare(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        static char Compare(char char1, char char2)
        {
            return (int)char1 > (int)char2 ? char1 : char2;
        }

        static string Compare(string str1, string str2)
        {
            int compare = str1.CompareTo(str2);

            if(compare > 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }

    }
}
