namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputString = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            if (inputString[0].Length >= inputString[1].Length)
            {
                foreach (var argumnets in inputString[0])
                {
                    Console.WriteLine(argumnets);
                }
            }
            else
            {
                foreach (var argumnets in inputString[1])
                {
                    Console.WriteLine(argumnets);
                }
            }
        }
    }
}