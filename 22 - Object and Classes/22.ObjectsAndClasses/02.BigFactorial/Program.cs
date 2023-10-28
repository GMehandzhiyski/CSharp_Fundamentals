using System.Numerics;

namespace _02.BigFactorial

{
    public class Program
    {
        static void Main(string[] args)
        {
            BigInteger factrial = 1;

            int numberFactorial = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numberFactorial; i++)
            {
                factrial *= i;

            }
            Console.WriteLine(factrial);
        }
    }
}