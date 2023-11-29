
using System.Linq;

namespace _04.MixedupLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                  .ToList();
            List<int> newList = new List<int>();
            List<int> finalList = new List<int>();

            //secondList.Reverse();
            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = secondList.Count - 1; j >= 0; j--)
                {
                    if (firstList.Count <= 0
                        || secondList.Count <= 0)
                    {
                        break;
                    }
                    newList.Add(firstList[i]);
                    firstList.Remove(firstList[i]);

                    newList.Add(secondList[j]);
                    secondList.Remove(secondList[j]);
                  
                }
               
                if (firstList.Count <= 0
                    && secondList.Count <= 0)
                {
                    break;
                }
            }

            foreach (var currNumber in newList)
            {
                bool isNumberBetwenRage = CheckValue(currNumber, firstList, secondList);
                if (isNumberBetwenRage)
                {
                    finalList.Add(currNumber);
                }
            }

            finalList.Sort();
            Console.WriteLine(string.Join(" ", finalList));

        }

        private static bool CheckValue(int currNumber, List<int> firstList, List<int> secondList)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            if (firstList.Count > secondList.Count)
            {
                firstNumber = firstList[0];
                secondNumber = firstList[1];
            }
            else
            {
                firstNumber = secondList[secondList.Count - 1];
                secondNumber = secondList[secondList.Count - 2];
            }

            bool isNumberBetwenRage = false;
            if (firstNumber > secondNumber)
            {
                if (firstNumber > currNumber
                    && secondNumber < currNumber)
                {
                    isNumberBetwenRage = true;
                }
            }
            else
            {
                if (firstNumber < currNumber
                    && secondNumber > currNumber)
                {
                    isNumberBetwenRage = true;
                }
            }
            return isNumberBetwenRage;
        }
    }
}