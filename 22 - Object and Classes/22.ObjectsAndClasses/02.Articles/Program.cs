namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int numberCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCommands; i++) 
            {
                string [] command = Console.ReadLine()
                    .Split(": ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Edit")
                {
                    inputList[1] = command[1];
                }
                else if (command[0] == "ChangeAuthor")
                {
                    inputList[2] = command[1];
                }
                else if (command[0] == "Rename")
                {
                    inputList[0] = command[1];
                }
            
            }
            Console.WriteLine($"{inputList[0]} - {inputList[1]}: {inputList[2]}");



        }
    }
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
    }
}