using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ');
            string[] second = Console.ReadLine().Split(' ');

            Console.WriteLine(string.Join(' ', second.Where(x => first.Contains(x)).ToArray()));
        }
    }
}
