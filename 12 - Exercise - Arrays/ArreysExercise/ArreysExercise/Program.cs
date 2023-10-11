using System.Runtime.InteropServices;

namespace ArreysExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {    // how to create empty string ?????
            int []  String1 = new int[0];
            int bestValue = 2;
            int bestCaunter = 3;


            for (int i = 0; i < bestCaunter; i++)
            {
                String1[i] = bestValue;
            
            }

            Console.WriteLine(string.Join(" ", String1));
            
        }
    }
}