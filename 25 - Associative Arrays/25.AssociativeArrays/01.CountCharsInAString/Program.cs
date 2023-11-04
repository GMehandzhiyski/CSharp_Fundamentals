namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char letter in inputString)
            {
                if (letter != ' ')
                { 
                    if (!letters.ContainsKey(letter))
                    {
                        letters.Add(letter, 1);
                    }
                    else
                    {
                        letters[letter]++;
                    }
                }
            }

            foreach (var currLetter in letters)
            {
                Console.WriteLine($"{currLetter.Key} -> {currLetter.Value}");
            }

        }
    }
}