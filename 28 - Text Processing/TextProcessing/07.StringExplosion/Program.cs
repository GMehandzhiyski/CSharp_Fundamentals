using System.Diagnostics.Metrics;
using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            //StringBuilder  sb = new StringBuilder();
            int inputStringCounter = 0;
            int countWhile = 0;
            int memoryLastRemoveIndex = 0;
            int bomb = 0;
            bool secondIsLetter = false;
            
            while (bomb != -1)
            {


                bomb = inputString.IndexOf('>', inputStringCounter);
                int powerIndex = (bomb + 1);
                


                if (bomb == -1)
                {
                    Console.WriteLine(inputString);
                    return;
                }

              
                int power = 0;

                if (char.IsDigit(inputString[powerIndex]))
                {
                    power = (int)inputString[powerIndex] - '0';
                    secondIsLetter = false;
                }
                else
                {
                    power = memoryLastRemoveIndex;
                    secondIsLetter = true;
                }

                // 2
                int counterRemoveIndex = 0;
                while (power != 0 
                        || memoryLastRemoveIndex != 0)
                {
                    bomb = inputString.IndexOf('>', inputStringCounter);
                    powerIndex = (bomb + 1);
                    // if index is > continue, increase counterIndex

                    // peter>62sis>1a>2akarate>4hexmaster
                    // abv>1>1>2>2asdasd

                    if (inputString[(powerIndex + counterRemoveIndex) + 1] == '>')
                    {
                        memoryLastRemoveIndex = inputString[powerIndex + counterRemoveIndex] - '0';
                        inputString = inputString.Remove(powerIndex + counterRemoveIndex, 1);
                        power--;
                        if (secondIsLetter)
                        {
                            counterRemoveIndex = 0;
                        }
                        else
                        {
                            counterRemoveIndex++;
                            
                        }

                    }
                    else
                    {
                        memoryLastRemoveIndex = inputString[powerIndex] - '0';
                        inputString = inputString.Remove(powerIndex, 1);
                        power--;
                        if (secondIsLetter)
                        {
                            counterRemoveIndex = 0;
                        }
                        else
                        {
                            counterRemoveIndex++;
                        }
                    }
                    while (countWhile == 0)
                    {
                        inputStringCounter = bomb;
                        countWhile++;
                    }
                    inputStringCounter++;
                }


                
            }

            
        }
    }
}