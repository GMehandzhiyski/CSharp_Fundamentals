using System;

namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = int.Parse(Console.ReadLine());
            long secondNumber = int.Parse(Console.ReadLine());
            long thirdNumber = int.Parse(Console.ReadLine());
            long fourthNumber = int.Parse(Console.ReadLine());

            long result = ((firstNumber + secondNumber) / thirdNumber) * fourthNumber;
            Console.WriteLine(result);
        }
    }
}
