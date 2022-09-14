using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numArticles; i++)
            {
                string[] currArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                Article article = new Article(currArticle[0], currArticle[1], currArticle[2]);
                articles.Add(article);
            }

            string command = Console.ReadLine();

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
