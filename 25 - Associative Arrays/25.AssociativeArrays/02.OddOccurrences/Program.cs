namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            Dictionary <string, int> occurrences = new Dictionary<string, int>(); 

            foreach (string currOccurrences in inputList) 
            {
                string wordLower = currOccurrences.ToLower();

                if (!occurrences.ContainsKey(wordLower))
                {
                    occurrences.Add(wordLower, 1);
                }
                else 
                {
                    occurrences[wordLower]++;
                } 
            }

            foreach (KeyValuePair <string,int> currWord in occurrences)
            {
                if (currWord.Value % 2 == 1)
                { 
                    Console.Write($"{currWord.Key} ");
                }
            }

        }
    }
}