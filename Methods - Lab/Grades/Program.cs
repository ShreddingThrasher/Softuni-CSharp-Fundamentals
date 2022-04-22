using System;

namespace MethodsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine(Grades(grade));
        }
        private static string Grades(double grade)
        {
            if (grade < 3.00)
            {
                return "Fail";
            }
            else if (grade < 3.50)
            {
                return "Poor";
            }
            else if (grade < 4.50)
            {
                return "Good";
            }
            else if (grade < 5.50)
            {
                return "Very good";
            }
            else
            {
                return "Excellent";
            }
        }
    }
}
