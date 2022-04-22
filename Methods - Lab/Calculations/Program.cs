using System;

namespace MethodsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Calculations(command, num1, num2);
        }
        private static void Calculations(string s, int num1, int num2)
        {
            switch (s)
            {
                case "add":
                    Console.WriteLine(num1 + num2);
                    break;
                case "multiply":
                    Console.WriteLine(num1 * num2);
                    break;
                case "subtract":
                    Console.WriteLine(num1 - num2);
                    break;
                case "divide":
                    Console.WriteLine(num1 / num2);
                    break;
            }
        }
    }
}
