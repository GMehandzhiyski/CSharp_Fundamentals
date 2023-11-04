namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> inputNumbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            foreach (int currNumber in inputNumbers) 
            {
                if (!numbers.ContainsKey(currNumber))
                {   
                    numbers.Add(currNumber, 1);
                }
                else
                {
                    numbers[currNumber]++;
                }
            
            
            }

            //Method print
            PrintNumbers(numbers);
        }

        private static void PrintNumbers(SortedDictionary<int, int> numbers)
        {   
            foreach (KeyValuePair <int,int> currNumber in numbers) 
            { 
                Console.WriteLine($"{currNumber.Key} -> {currNumber.Value}");
            }
        }
    }
}