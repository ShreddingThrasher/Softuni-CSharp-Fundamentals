using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                while(text.IndexOf(bannedWords[i]) >= 0)
                {
                    string replacement = new string('*', bannedWords[i].Length);

                    text = text.Replace(bannedWords[i], replacement);
                }
            }

            Console.WriteLine(text);
        }
    }
}
