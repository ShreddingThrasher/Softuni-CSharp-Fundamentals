using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char _operator = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = Calculate(num1, _operator, num2);

            Console.WriteLine(result);
        }

        static int Calculate(int num1, char _operator, int num2)
        {
            int result = 0;

            switch (_operator)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }

            return result;
        }
    }
}
