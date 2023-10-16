using System.Diagnostics.CodeAnalysis;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= inputNumber; i++)
            {
                bool isDevisibleBy8 = DevivisibleBy8(i);
                bool isNumberOdd = IsNumberOdd(i);

                if (isDevisibleBy8 && isNumberOdd) 
                {
                    Console.WriteLine(i);
                }
            }



        }

        private static bool IsNumberOdd(int i)
        {
            string middleNumber = i.ToString();
            int numberFromString = 0;
            bool numberIsOdd= false;

            for (int j = 0; j < middleNumber.Length; j++)
            {
                numberFromString = int.Parse(middleNumber[j].ToString());

                if (numberFromString % 2 != 0)
                { 
                   numberIsOdd= true;
                    break;
                }

            }
                return  numberIsOdd;    
        }

        private static bool DevivisibleBy8(int i)
        {
            bool isDevilbeBy8 = false;  
            string middleNumber = i.ToString();
            int sumOfDigits = 0;
            int numberFromString = 0;
           
            for (int j = 0; j < middleNumber.Length; j++)
            {
                numberFromString = int.Parse(middleNumber[j].ToString());

                sumOfDigits += numberFromString;

            }
            if (sumOfDigits % 8 == 0)
            {
                isDevilbeBy8 = true;
            }

            return isDevilbeBy8;

        }
    }
}
