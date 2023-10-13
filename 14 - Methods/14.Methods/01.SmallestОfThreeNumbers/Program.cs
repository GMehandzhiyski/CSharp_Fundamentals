using System;

namespace _01.SmallestОfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            smallestInt(number1, number2, number3);
        }


        // 600
        // 342
        // 123
        private static void smallestInt(int number1, int number2, int number3)
        {
            if (number1 <= number2)
            {
                if (number1 <= number3)
                {
                    Console.WriteLine(number1);
                }
                else
                {
                    Console.WriteLine(number3);
                }
           

            }
            else
            {
                if (number2 <= number3)
                {
                    Console.WriteLine(number2);
                }
                else 
                {
                    Console.WriteLine(number3);
                }
            }
        }
    }
}