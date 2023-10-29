namespace _103._Articles_2._0
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Articles> finalList = new List<Articles>();   

            for (int i = 0; i < number; i++) 
            {
                List <string> inputList = Console.ReadLine()
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string title = inputList[0];
                string content = inputList[1];
                string autor = inputList[2];    

                Articles articles = new Articles(title, content, autor);
                finalList.Add(articles);

            }

            foreach (Articles articles in finalList) 
            {
                Console.WriteLine($"{articles.Title} - {articles.Content}: {articles.Autor} ");
            }

        }
        class Articles
        {
            public Articles(string title, string content, string autor)
            {
                Title = title;
                Content = content;
                Autor = autor;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Autor { get; set; }

        }
    }
}