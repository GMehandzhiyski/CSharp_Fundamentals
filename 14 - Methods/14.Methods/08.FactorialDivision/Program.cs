namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstNumFactorial = CalculateFactorial(firstNumber);
            double secondNumFactorial = CalculateFactorial(secondNumber);
            Console.WriteLine($"{firstNumFactorial / secondNumber:f2}");

        }

        private static int CalculateFactorial(int firstNumber)
        {
            if (firstNumber == 0)
                return 1;
            else
                return firstNumber * CalculateFactorial(firstNumber - 1);
        }
      
    }
}