namespace _02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            string middleString = string.Empty;
            foreach (var currChar in inputString)
            {
                if (currChar > startChar
                    && currChar < endChar)
                {
                    middleString += currChar;
                }
            }
            int sumOfChar = 0;
            foreach (var currChar in middleString)
            {
                int charToInt = currChar;
                sumOfChar += charToInt;
            }

            Console.WriteLine(sumOfChar);
        }
    }
}