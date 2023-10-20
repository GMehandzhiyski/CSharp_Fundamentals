namespace _02.ShootForTheWin
{
    /*
    24 50 36 70
    0
    4
    3
    1
    End


         */

    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> inputList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int shoot = -1;
            string inputArguments;
            int countShoot = 0;

            while ((inputArguments = Console.ReadLine()) != "End")
            {
                int index = int.Parse(inputArguments);
                bool isIndexValid = ChekValidIndex(index, inputList);
                if (isIndexValid)
                {
                    int targetValue = inputList[index];
                    inputList[index] = shoot;
                    countShoot++;

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] != shoot)
                        {
                            if (targetValue < inputList[i]) //-
                            {
                                inputList[i] -= targetValue;


                            }
                            else if (targetValue >= inputList[i]) //+
                            {
                                inputList[i] += targetValue;
                            }

                        }

                    }
                }
                else
                {
                    continue;
                }


            }

            Console.WriteLine($"Shot targets: {countShoot} -> {string.Join(' ', inputList)} ");
        }

        private static bool ChekValidIndex(int index, List<int> inputList)
        {
            return ((0 <= index) && (index < inputList.Count));
        }
    }
}