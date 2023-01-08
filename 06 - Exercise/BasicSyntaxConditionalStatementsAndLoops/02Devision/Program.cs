using System;

namespace _02Devision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int magicNumber = 0;

            if (number % 10 == 0)
            {
                magicNumber = 10;
            }
            else if (number % 7 == 0)
            {
                magicNumber = 7;
            }
            else if (number % 6 == 0)
            {
                magicNumber = 6;
            }
            else if (number % 3 == 0)
            {
                magicNumber = 3;
            }
            else if (number % 2 == 0)
            {
                magicNumber = 2;
            }
            else
            {
                Console.WriteLine($"Not divisible");
                return;
            }
                Console.WriteLine($"The number is divisible by {magicNumber}.");
        }
    }
}
