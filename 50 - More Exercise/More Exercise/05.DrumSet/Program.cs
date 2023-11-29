namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saveMoney = decimal.Parse(Console.ReadLine());

            List<int> drumQualityFirst = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> drumQualityCurr = new List<int>();
            drumQualityCurr.AddRange(drumQualityFirst);

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int decreasePower = int.Parse(arguments);
                for (int i = 0; i < drumQualityCurr.Count; i++)
                {
                    drumQualityCurr[i] -= decreasePower;
                    if (drumQualityCurr[i] <= 0)
                    {
                        if (saveMoney >= (drumQualityFirst[i] * 3))
                        {
                            saveMoney -= drumQualityFirst[i] * 3;
                            drumQualityCurr[i] = drumQualityFirst[i];
                        }
                        else
                        {
                            drumQualityCurr.RemoveAt(i);
                            drumQualityFirst.RemoveAt(i);
                            i--;
                        }
                    }
                 }
                  
            }

            Console.WriteLine(string.Join(" ",drumQualityCurr));
            Console.WriteLine($"Gabsy has {saveMoney:f2}lv.");
        }
    }
}