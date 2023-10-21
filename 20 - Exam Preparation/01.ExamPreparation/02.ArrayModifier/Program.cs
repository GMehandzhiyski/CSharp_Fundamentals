namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string arguments;
            while ((arguments = Console.ReadLine()) != "end")
            {
                string[] commands = arguments.Split();

                if (commands[0] == "swap")
                {
                    int index1 = int.Parse(commands[1]);
                    int index2 = int.Parse(commands[2]);

                    bool isIndexValid = CheckValidIndex(index1, index2, inputList);
                    if (isIndexValid)
                    {

                        int savePlaceIndex1 = inputList[index1];
                        int savePlaceIndex2 = inputList[index2];
                        inputList[index2] = savePlaceIndex1;
                        inputList[index1] = savePlaceIndex2;

                    }
                    else
                    {
                        continue;
                    }

                }
                else if (commands[0] == "multiply")
                {
                    int index1 = int.Parse(commands[1]);
                    int index2 = int.Parse(commands[2]);
                    bool isIndexValid = CheckValidIndex(index1, index2, inputList);

                    if (isIndexValid) 
                    {
                       int result = inputList[index1] * inputList[index2];
                        inputList[index1] = result;
                    }

                }
                else if (commands[0] == "decrease")
                {
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        inputList[i] -= 1;

                    }
                }


            }

            Console.WriteLine(string.Join(", ",inputList));
        }

        private static bool CheckValidIndex(int index1, int index2, List<int> inputList)
        {

            return (((0 <= index1) && (index1 <= inputList.Count))
                     && (0 <= index2) && (index2 <= inputList.Count)
                     && index1 != index2);
        }
    }
}