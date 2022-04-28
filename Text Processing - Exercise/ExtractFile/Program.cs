using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int start = path.LastIndexOf("\\");
            int end = path.LastIndexOf(".");

            string filename = path.Substring(start + 1, (end - start) - 1);
            string extension = path.Substring(end + 1, (path.Length - end) - 1);


            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
