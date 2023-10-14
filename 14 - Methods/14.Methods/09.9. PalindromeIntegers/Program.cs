namespace _09._9._PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reverseNumber = null;
            string number = null;
            while ((number = Console.ReadLine()) != "END")
            {
                
                foreach (char c in number.Reverse())
                {
                    reverseNumber += c.ToString();
                }

                if (reverseNumber == number)
                {
                    Console.WriteLine("true");
                    reverseNumber = null;
                }
                else 
                { 
                    Console.WriteLine("false");
                    reverseNumber = null;
                }
                //Console.WriteLine(reverseNumber);

            }




        }
    }
}