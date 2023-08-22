using System;

namespace PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write(i);
                Console.Write(" ");
                
                sumOfNumbers += i;
            }
            Console.WriteLine("");
            Console.WriteLine($"Sum: {sumOfNumbers}");   
        }
    }
}
