namespace _03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> allBiggerNumberList = new List<int>();
            List<int> finalList = new List<int>();
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            decimal sumOfList = numbers.Sum();
            decimal averageValue = (sumOfList / numbers.Count);
            int numbersCount = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageValue)
                {
                    allBiggerNumberList.Add(numbers[i]);

                }


            }
            if (allBiggerNumberList.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            if (allBiggerNumberList.Count >= 5)
            {
                for (int j = 0; j <= (allBiggerNumberList.Count + 1); j++)
                {
                    //finalList[j] = allBiggerNumberList.Max();
                    int maxValue = allBiggerNumberList.Max();
                    finalList.Add(maxValue);
                    allBiggerNumberList.Remove(maxValue);
                    numbersCount++;
                    if (numbersCount == 6)
                    {
                        break;
                    }
                }
            }
            else
            {
                finalList.AddRange(allBiggerNumberList);
            }
            Console.WriteLine(string.Join(" ", finalList.OrderByDescending(n => n).ToList()));
            return;

        }
    }
}