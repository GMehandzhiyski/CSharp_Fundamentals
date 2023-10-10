namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string temp = "";
           
            for (int i = 0; i < array.Length; i++)
            {
                int curr = array[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (curr <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }

                }

                if (isTopInteger)
                {
                    temp += curr + " ";
                }

            }

           

            Console.WriteLine(string.Join(" ", temp));    
        }
    }
}