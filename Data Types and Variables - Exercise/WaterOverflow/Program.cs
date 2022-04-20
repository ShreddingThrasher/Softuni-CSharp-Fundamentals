using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int water = 0;
            int input = 0;

            for (int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());

                if (water + input > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    water += input;
                }
            }

            Console.WriteLine(water);
        }
    }
}
