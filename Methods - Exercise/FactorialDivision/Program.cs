using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"{FactorialDivision(num1, num2):F2}");
        }

        static double FactorialDivision(double num1, double num2)
        {
            return Factorial(num1) / Factorial(num2);
        }

        static double Factorial(double num)
        {
            double factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
