using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                if(usernames[i].Length < 3 || usernames.Length > 16)
                {
                    continue;
                }

                bool isValid = true;

                for (int j = 0; j < usernames[i].Length; j++)
                {
                    if (!char.IsLetterOrDigit(usernames[i][j]) && usernames[i][j] != '-' && usernames[i][j] != '_')
                    {
                        isValid = false;
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(usernames[i]);
                }
            }
        }
    }
}
