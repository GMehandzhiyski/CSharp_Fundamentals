namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            for (int i = 0; i < secondString.Length; i++)
            {
                int isIndexValid = secondString.LastIndexOf(firstString);
                secondString = secondString.Remove(isIndexValid, firstString.Length);
            }

            Console.WriteLine(secondString);
        }
    }
}