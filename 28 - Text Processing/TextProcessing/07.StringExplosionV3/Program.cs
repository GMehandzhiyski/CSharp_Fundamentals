using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            int bombPower = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (bombPower > 0 && inputString[i] != '>')
                {
                    inputString = inputString.Remove(i, 1); // Remove char on this index
                    bombPower--; // One bomb is used
                    i--; // after remove next char is moved 1 position, so return counter i to this char, decreasing i by 1  
                }
                else if (inputString[i] == '>')
                {
                    bombPower += int.Parse(inputString[i + 1].ToString()); // takes the digit after '>' - bomb strength and add to bomb
                }
            }
            Console.WriteLine(inputString);
        }
    }
}