namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputWords = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string inputText = Console.ReadLine();

            for (int i = 0; i < inputWords.Count; i++)
            {

                string replaceString = string.Empty;
                for (int j = 0; j < inputWords[i].Length; j++)
                {
                    replaceString = replaceString + "*";
                }

                inputText = inputText.Replace(inputWords[i], replaceString);

            }
           
            Console.WriteLine(inputText);
           
        }
    }
}