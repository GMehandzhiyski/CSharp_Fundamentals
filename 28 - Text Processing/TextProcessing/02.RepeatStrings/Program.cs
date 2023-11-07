namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] inputString = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string finalString = string.Empty;
            foreach (string word in inputString)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    finalString += word;
                }
            }

            Console.WriteLine(finalString);
        }
    }
}