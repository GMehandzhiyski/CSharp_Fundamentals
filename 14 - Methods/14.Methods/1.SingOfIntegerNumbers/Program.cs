namespace _1.SingOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            typeOfNumber(number);
        }

        static void typeOfNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
            
        }
    }
} 