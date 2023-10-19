namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string [] stringArray = Console.ReadLine()
                .Split('|',StringSplitOptions.RemoveEmptyEntries);

            List<string> finalArary = RemoveEmptySpace(stringArray);
            Console.WriteLine(string .Join(" ", finalArary)); 

        }

        private static List<string> RemoveEmptySpace(string[] stringArray)
        {
            List<string> result = new List<string>();
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                string str = stringArray[i];
                string[] arrays = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(arrays);
            }

            return result;
        }
    }
}