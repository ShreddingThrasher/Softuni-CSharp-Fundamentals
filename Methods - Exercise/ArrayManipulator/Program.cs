using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string input;

            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ');

                switch (command[0])
                {
                    case "exchange":

                        int index = int.Parse(command[1]);

                        if(index < 0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }

                        Exchange(arr, index);
                        break;

                    case "max":

                        string conditionMax = command[1];

                        int maxIndex = Max(arr, conditionMax);

                        if(maxIndex != -1)
                        {
                            Console.WriteLine(maxIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;

                    case "min":

                        string conditionMin = command[1];

                        int minIndex = Min(arr, conditionMin);

                        if(minIndex != -1)
                        {
                            Console.WriteLine(minIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    case "first":

                        string conditionFirst = command[2];
                        int countFirst = int.Parse(command[1]);

                        if(countFirst > arr.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }

                        PrintArray(First(arr, countFirst, conditionFirst));

                        break;
                    case "last":

                        string conditionLast = command[2];
                        int countLast = int.Parse(command[1]);

                        if(countLast > arr.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }

                        PrintArray(Last(arr, countLast, conditionLast));

                        break;
                }
            }

            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static void Exchange(int[] arr, int index)
        {
            int[] exchanged = new int[arr.Length];
            int x = 0;

            for (int i = index + 1; i < arr.Length; i++)
            {
                exchanged[x] = arr[i];
                x++;
            }

            for (int i = 0; i <= index; i++)
            {
                exchanged[x] = arr[i];
                x++;
            }

            Array.Copy(exchanged, arr, arr.Length);
        }

        static int Max(int[] arr, string condition)
        {
            int index = -1;
            int maxEven = int.MinValue;
            int maxOdd = int.MinValue;

            if(condition == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0 && arr[i] >= maxEven)
                    {
                        maxEven = arr[i];
                        index = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] % 2 != 0 && arr[i] >= maxOdd)
                    {
                        maxOdd = arr[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        static int Min(int[] arr, string condition)
        {
            int index = -1;
            int minEven = int.MaxValue;
            int minOdd = int.MaxValue;

            if (condition == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0 && arr[i] <= minEven)
                    {
                        minEven = arr[i];
                        index = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0 && arr[i] <= minOdd)
                    {
                        minOdd = arr[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        static int[] First(int[] arr, int count, string condition)
        {
            if(condition == "even")
            {
                return arr.Where(x => x % 2 == 0).Take(count).ToArray();
            }
            else
            {
                return arr.Where(x => x % 2 != 0).Take(count).ToArray();
            }
        }

        static int[] Last(int[] arr, int count, string condition)
        {
            if (condition == "even")
            {
                return arr.Reverse().Where(x => x % 2 == 0).Take(count).ToArray();
            }
            else
            {
                return arr.Reverse().Where(x => x % 2 != 0).Take(count).ToArray();
            }
        }
    }
}
