using System.Security.Cryptography.X509Certificates;

namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < number; i++) 
            {
                string wordKey = Console.ReadLine();
                string synonymValue = Console.ReadLine();


                if (!words.ContainsKey(wordKey))
                {
                    words.Add(wordKey, new List<string>());
                    words[wordKey].Add(synonymValue);
                }
                else
                {
                    words[wordKey].Add(synonymValue);

                }
             
            
            }

            foreach (var currWord in words)
            {
                string finalValues = string.Empty;
                foreach (var currValue in currWord.Value)
                {
                    //Console.Write($"{string.Join(", ", currValue/*.Substring(0,currValue.Length - 2)*/)}, ");
                   
                    finalValues += currValue + ", ";
                }

                Console.WriteLine($"{currWord.Key} - {finalValues.Substring(0,finalValues.Length - 2)}");
            }
               
        }
    }
}