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
            double result = firstNumFactorial / secondNumber;

            Console.WriteLine($"{result:f2}");

        }

        private static double CalculateFactorial(int number)
        {
            double factorial = 1;
            for (int i = 1; i <= number; i++) 
            {
                factorial *= i;
            }

            return factorial;
        }
      
    }
}