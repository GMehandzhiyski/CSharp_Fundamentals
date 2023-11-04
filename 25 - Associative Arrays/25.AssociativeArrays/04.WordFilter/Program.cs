namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (string currWord in inputList) 
            {
                if (currWord.Length % 2 == 0)
                { 
                    Console.WriteLine(currWord);
                
                }
            
            }
        }
    }
}