using System;

namespace PrintAndSum
{
  public class Program
    {
        static void Main(string[] args)
        {
           int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startNum; i <= endNum; i++) 
            {
                sum = sum + i;
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.Write($"Sum: {sum} ");
        }
    }
}