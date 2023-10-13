namespace _04._4._PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string password = (Console.ReadLine());

            bool cheracktersIsValid = ContainCharacters(password);
            bool checkLatterAdnDigit = LatterAndDigit(password);
            bool checkTwoDigitis = TwoDigits(password);

            if (cheracktersIsValid && checkLatterAdnDigit &&  checkTwoDigitis)
            {
                Console.WriteLine("Password is valid");
            }
            else 
            {
                if (!cheracktersIsValid)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!checkLatterAdnDigit)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!checkTwoDigitis)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

            }

        }

        private static bool TwoDigits(string password)
        {
            int countDigits = 0;
            bool checkTwoDigitisTrue = false;

            foreach (int item in password)
            {
                if ((item >= 48 && item <= 57))
                {
                    countDigits ++;
                }

                if (countDigits >= 2)
                {
                    checkTwoDigitisTrue = true;
                }
                
            }

            return checkTwoDigitisTrue;

        }


        private static bool LatterAndDigit(string password)
        {
            bool latterAdnDigitTrue = false;
            foreach (int item in password)
            {
                if ((item >= 48 && item <= 57)
                    || (item >= 65 && item <= 90)
                    || (item >= 97 && item <= 122))
                {
                    latterAdnDigitTrue = true;
                }

                else 
                {
                    latterAdnDigitTrue = false;
                    break;
                }

            }

            return latterAdnDigitTrue;
        }

        private static bool ContainCharacters(string password)
        {

            return password.Length >= 6 && password.Length <= 10;

        }
    }
}