namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string vowels = "AEIOUaeiou";
            int value = 0;  


            foreach (char c in inputString)
            {
                if (vowels.Contains(c))
                {
                    //Console.Write(c);
                    value++;
                }
            }

            Console.WriteLine(value);
        }
    }
}