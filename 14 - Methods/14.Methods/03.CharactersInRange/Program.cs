using System.Runtime.InteropServices;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            char charOne =char.Parse( Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());
            int charOneInt = 0;
            int charTwoInt = 0;

            
            if (charOne <= charTwo)
            {
                charOneInt = (int)charOne;
                charTwoInt = (int)charTwo;

                PrintChar(charOneInt, charTwoInt);
            }
            else 
            {
                charOneInt = (int)charTwo;
                charTwoInt = (int)charOne;

                PrintChar(charOneInt, charTwoInt);
            }
            

        }

        private static void PrintChar(int charOneInt, int charTwoInt)
        {
            for (int i = charOneInt + 1 ; i < charTwoInt ; i++)
            {
                char result = (char)i;
                Console.Write($"{result} ");
            }    
        }
    }
}