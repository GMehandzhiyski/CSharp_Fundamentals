using System;

namespace _01.RandomizeWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            List <string> inputString = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            

            for (int i = 0; i < inputString.Count; i++)
            {
                Random random = new Random();
                int randomInt = random.Next(0, inputString.Count);

                string procesValue = inputString[i];
                string randomIndexValue= inputString[randomInt];

                inputString[randomInt] = procesValue;
                inputString[i] = randomIndexValue;
            }

            foreach (var item in inputString)
            {
                Console.WriteLine(item);
            }
        }
    }
}