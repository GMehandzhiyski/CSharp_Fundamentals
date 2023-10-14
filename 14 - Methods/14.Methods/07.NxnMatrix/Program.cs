namespace _07.NxnMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            string firstRow = "";
            for (int i = 0; i < number; i++)
            {
                firstRow += number + " ";
            }
            //Console.WriteLine(firstRow);    
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(firstRow);    
            }
        }
    }
}