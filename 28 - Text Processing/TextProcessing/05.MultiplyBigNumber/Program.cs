using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firtsNumberInput = Console.ReadLine();
            int secondNumberInput = int.Parse(Console.ReadLine());
            if (firtsNumberInput[0] <= '0'
                || secondNumberInput <= 0)
            {
                Console.WriteLine(0);
                return;
            }

                StringBuilder sb = new StringBuilder();
                int residue = 0;


                for (int i = firtsNumberInput.Length - 1; i >= 0; i--)
                {

                    int result = ResultcCharToInt(firtsNumberInput[i], secondNumberInput, residue);

                    int firstNumberResult = result / 10;
                    int secondNumber = result % 10;


                    sb.Insert(0, secondNumber);
                    residue = firstNumberResult;

                }
                if (residue != 0)
                {
                    sb.Insert(0, residue);
                }
            
           

            Console.WriteLine(sb.ToString());
        }

        private static int ResultcCharToInt(char currNumber, int secondNumberInput, int residue)
        {
            int currNumberInt = (int)currNumber - '0';
            int result = (currNumberInt * secondNumberInput) + residue;
            return result;
        }

        
    }
}