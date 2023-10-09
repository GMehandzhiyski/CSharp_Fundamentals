namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split().ToArray();
            string[] arrayTwo = Console.ReadLine().Split().ToArray();

            string result = "";

            for (int i = 0; i < arrayTwo.Length; i++) 
            {
    
                for (int j = 0; j < arrayOne.Length; j++) 
                {
                    if (arrayTwo[i] == arrayOne[j])
                    {
                        result += arrayTwo[i] + " ";
                    }
                
                }   
            
            }
             Console.WriteLine(result);

            //Console.WriteLine(string.Join(" ", arreyOne));
            //Console.WriteLine(string.Join(" ", arreyTwo));
        }
    }
}