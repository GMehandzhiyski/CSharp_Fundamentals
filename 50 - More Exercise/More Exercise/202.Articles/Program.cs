using System.Linq;

namespace _202.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string title = inputString[0];
            string content = inputString[1];
            string author = inputString[2];

            List<Article> articleList = new List<Article>();

            Article article = new Article(title, content, author);
            articleList.Add(article);

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = commands[0];
                string newText = commands[1];

                if (command == "Edit")
                {
                    EditContent(articleList, newText);
                }
                else if (command == "ChangeAuthor")
                {
                    ChangeAuthor(articleList,newText);
                }
                else if (command == "Rename")
                {
                    Rename(articleList, newText);
                }
            }

            Console.WriteLine($"{articleList[0].Title} -{articleList[0].Content}:{articleList[0].Author}");
        }

        private static void Rename(List<Article> articleList, string newText)
        {
            articleList[0].Title = newText;
        }

        private static void ChangeAuthor(List<Article> articleList, string newText)
        {
            articleList[0].Author = newText;
        }

        public static void EditContent(List<Article> articleList, string newText)
        {
            articleList[0].Content = newText;
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        
    }
}