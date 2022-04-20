using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());

            if (input < 1 || input > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[input - 1]);
            }
        }
    }
}
