namespace _08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int ii = 1; ii <= i; ii++)
                {
                    Console.Write(i + " "); 
                  

                }
                Console.WriteLine();
            }
        }
    }
}