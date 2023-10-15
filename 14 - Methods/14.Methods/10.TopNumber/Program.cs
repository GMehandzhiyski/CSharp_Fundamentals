namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());


            for (int i = 1; i <= inputNumber; i++)
            {
                (int resultDigits, bool isDigitOdd) = CalculateSumOfDigidts(i);
                bool isDivideBy8 = DevideBy8(resultDigits);

                if (isDivideBy8 && isDigitOdd)
                {
                    Console.WriteLine(i);
                }

            }
        }

        private static (int, bool) CalculateSumOfDigidts(int i)
        {
            string stringNumber = i.ToString();
            int resultDigits = 0;
            bool isDigitOdd = false;

            for (int j = 0; j < stringNumber.Length; j++)
            {
                isDigitOdd = false;
                int numberAfterString = int.Parse(stringNumber[j].ToString());

                if (numberAfterString % 2 == 1)
                {
                    isDigitOdd = true;
                }
                

                resultDigits += numberAfterString;
            }

            return (resultDigits, isDigitOdd);
            //return resultDigits;

        }
        private static bool DevideBy8(int resultDigits)
        {
            bool isDevide = false;
            if (resultDigits % 8 == 0)
            {
                isDevide = true;
            }

            return isDevide;
        }
    }
}
