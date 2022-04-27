using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());

            Article a = new Article(article[0], article[1], article[2]);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(": ");

                switch (input[0])
                {
                    case "Edit":
                        a.Edit(input[1]);
                        break;
                    case "Rename":
                        a.Rename(input[1]);
                        break;
                    case "ChangeAuthor":
                        a.ChangeAuthor(input[1]);
                        break;
                }
            }

            Console.WriteLine(a.ToString());
        }
    }
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newName)
        {
            this.Title = newName;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
