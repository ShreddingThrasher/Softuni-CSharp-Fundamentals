using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.",
                                 "Such a great product.",
                                 "I always use that product.",
                                 "Best product of its category.",
                                 "Exceptional product.",
                                 "I can’t live without this product." };

            string[] events = { "Now I feel good.",
                                "I have succeeded with this product.",
                                "Makes miracles. I am happy of the results!",
                                "I cannot believe but now I feel awesome.",
                                "Try it yourself, I am very satisfied.",
                                "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random phrasesRnd = new Random();
            Random eventsRnd = new Random();
            Random authorsRnd = new Random();
            Random citiesRnd = new Random();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string phrase = phrases[phrasesRnd.Next(0, phrases.Length)];
                string ev = events[eventsRnd.Next(0, events.Length)];
                string author = authors[authorsRnd.Next(0, authors.Length)];
                string city = cities[citiesRnd.Next(0, cities.Length)];

                Console.WriteLine($"{phrase} {ev} {author} - {city}.");
            }
        }
    }
}
