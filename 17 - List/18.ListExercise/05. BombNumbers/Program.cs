/*
1 2 2 4 2 2 2 2 5 4 3 6 9
1 4 2 2 2 2 5 4 3 6 9
1 2 2 5 4 3 6 9
1 2 4 3 6 9
1 2 9
*/




namespace _05._BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] inputValues = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int bomb = int.Parse(inputValues[0]);
            int power = int.Parse(inputValues[1]);
            if (power < 0)
            {
                power = 0;
            }

            while (inputList.Contains(bomb) != false)
            {
                int indexOfBomb = inputList.IndexOf(bomb);
                int startIndex;
                int count = 0;

                if (indexOfBomb >= power)
                {
                    startIndex = (indexOfBomb - power);
                }
                else
                {
                    startIndex = 0;
                }

                //                 5   -       3 = 3
                if (((inputList.Count - 1) - indexOfBomb) > power)
                {
                    count = (power * 2) + 1;
                }
                else
                {
                    count = (((inputList.Count - 1) - indexOfBomb) + power + 1);
                    if (count > inputList.Count)
                    {
                        count = inputList.Count;
                    }
                }

                inputList.RemoveRange(startIndex, count);

            }

            Console.WriteLine(inputList.Sum());

        }
    }
}