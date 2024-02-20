namespace _03.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStirng = Console.ReadLine();
            List<int> digits = new List<int>();
            List<string> nonNumbers = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            int stringLenght = inputStirng.Length;

            for (int i = 0; i < stringLenght; i++)
            {

                if ((inputStirng.Length > i) 
                    && char.IsDigit(inputStirng[i]))  
                {
                    digits.Add(inputStirng[i] - 48);
                    inputStirng = inputStirng.Remove(i, 1);
                    i--;
                }  
            }

            foreach (var currChar in inputStirng)
            {
                string currCharString = currChar.ToString();
                nonNumbers.Add(currCharString);
            }

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    skipList.Add(digits[i]);
                }
                else
                {
                    takeList.Add(digits[i]);
                }

            }

            for (int i = 0; i < takeList.Count; i++)
            {
                foreach (var takeNumber in takeList)
                {
                    foreach (var skipNumber in skipList)
                    {
                        Console.WriteLine("");


                    }

                }


            }

            Console.WriteLine(string.Join(", ", takeList));
            Console.WriteLine(string.Join(" ", digits));
            Console.WriteLine(string.Join(", ", skipList));
            Console.WriteLine(string.Join(" ",nonNumbers));
        }
    }
}