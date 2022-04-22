using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateTriangleArea(width, height));
        }

        static int CalculateTriangleArea(int width, int height)
        {
            return width * height;
        }
    }
}
