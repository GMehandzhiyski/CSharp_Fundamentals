namespace _01.Messaging
{
    /*
    29
    13
    23
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            string text = Console.ReadLine();

            string[] numberString = number
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<int> listOfNumber = new List<int>();

            foreach (var currString in numberString)
            {
                int tempNumber = 0;
                foreach (var currNumber in currString)
                {
                    //tempNumber += (char)currNimber; 
                    tempNumber += (int)currNumber - 48;
                }
                listOfNumber.Add(tempNumber);
            }

            string finalString = string.Empty;
            for (int i = 0; i < listOfNumber.Count; i++)
            {
                if (listOfNumber[i] > text.Length)
                {
                    // 1 = 29 - 28
                    int realLoopValue = listOfNumber[i] - text.Length;
                    finalString += text[realLoopValue];
                    text = text.Remove(realLoopValue,1 );
                }
                else
                {
                    finalString += text[listOfNumber[i]];
                    text = text.Remove(listOfNumber[i], 1);
                }

            }

            Console.WriteLine(finalString);
        }
    }
}