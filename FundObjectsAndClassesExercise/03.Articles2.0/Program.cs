using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Articles> articles = new List<Articles>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Articles article = new Articles(input[0], input[1], input[2]);

                articles.Add(article);

            }

            string criteriaPrinting = Console.ReadLine();

            if (criteriaPrinting == "title")
            {
                var orderedByTitle = articles.OrderBy(article => article.Title).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, orderedByTitle));
            }
            else if (criteriaPrinting == "content")
            {
                var orderedByContent = articles.OrderBy(article => article.Content).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, orderedByContent));
            }
            else if (criteriaPrinting == "author")
            {
                var orderedByAuthor = articles.OrderBy(article => article.Author).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, orderedByAuthor));
            }

        }
    }

    public class Articles
    {
        public Articles(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
