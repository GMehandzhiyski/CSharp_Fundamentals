namespace _07.StringExplosionV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int bombIndex = 0;
            int startSearch = 0;
            int powerIndex = 0;
            int memoryLastIndex = 0;
            int countFor = 0;
            int bombOffset = 0;
            int countWhile = 0;

            while (bombIndex != -1)
            {
                bombIndex = FoundBombIndex(inputString, startSearch);
                powerIndex = FoundPowerIndex(bombIndex);

                if (char.IsDigit(inputString[powerIndex]))
                {
                    countFor = inputString[powerIndex] - '0';
                }
                else
                {
                    countFor = memoryLastIndex;
                }


                for (int i = 0; i < countFor; i++)
                {
                    if (inputString[(powerIndex + i) + bombOffset] != '>')
                    {
                       
                        if (char.IsDigit(inputString[(powerIndex + i) + bombOffset]))
                        {
                            memoryLastIndex = inputString[((powerIndex + i) + bombOffset)] - '0';
                        }

                        inputString = inputString.Remove((powerIndex + i) + bombOffset, 1);
                    }
                  
                    
                    while (countWhile == 0)
                    {
                        startSearch = bombIndex;
                        countWhile++;
                    }
                    startSearch++;

                }
            }
        }

        private static int FoundPowerIndex(int bombIndex)
        {
            return bombIndex + 1;
        }

        private static int FoundBombIndex(string inputString, int startSearch)
        {
            int bombIndex = inputString.IndexOf('>', startSearch);
            return bombIndex;
        }
    }
}