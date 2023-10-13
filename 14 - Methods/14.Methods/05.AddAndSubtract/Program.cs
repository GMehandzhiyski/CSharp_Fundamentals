namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int sumOfNumber = SumOfNumber(number1, number2);
            int subtractsOfNumbers = SubtractsOfNumbers(sumOfNumber, number3);

            Console.WriteLine(subtractsOfNumbers);



        }

        private static int SubtractsOfNumbers(int sumOfNumber, int number3)
        {
            return sumOfNumber - number3;
        }

        private static int SumOfNumber(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}