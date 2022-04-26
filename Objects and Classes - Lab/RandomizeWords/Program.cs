using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            RandomizeArray(input);

            Console.WriteLine(string.Join('\n', input));
        }

        static void RandomizeArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Random rnd = new Random();

                string temp = arr[i];
                int rndIndex = rnd.Next(0, arr.Length);
                arr[i] = arr[rndIndex];
                arr[rndIndex] = temp;
            }
        }
    }
}
