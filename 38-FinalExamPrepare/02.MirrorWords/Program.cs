using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            string regexPatern = @"[\@]{1}([A-Za-z]+)[\@]{2}([A-Za-z]+)[\@]{1}|[\#]{1}([A-Za-z]+)[*\#]{2}([A-Za-z]+)[\#]{1}";
            string inputText = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputText, regexPatern);

            Dictionary<string, string> wordsDictionary = new Dictionary<string, string>();

            StringBuilder sb = new StringBuilder();
            
            foreach (Match match in matches)
            {
                string words = match.Value;
                string[] word = words
                    .Split(new char[] { '#', '@' }, StringSplitOptions.RemoveEmptyEntries);
                string FirstWord = word[0];
                string SecondWord = word[1];
                wordsDictionary.Add(FirstWord, SecondWord);
            }

            

            if (wordsDictionary.Count == 0)
            {
                PrintInCorrectResult();
                return;
            }

            PrintCorrectResult(wordsDictionary, sb);

            string mirrorWords = CheckValidMirrorWords(wordsDictionary, sb);

            if (mirrorWords.Length == 0)
            {
                PrintCorrectResultWithoutMirror();
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(sb.ToString().TrimEnd(',',' '));
            }
            

        }

        private static void PrintInCorrectResult()
        {
            Console.WriteLine("No word pairs found!");
            Console.WriteLine("No mirror words!");
        }

        private static void PrintCorrectResultWithoutMirror()
        {
            Console.WriteLine("No mirror words!");
        }

        private static string CheckValidMirrorWords(Dictionary<string, string> wordsDictionary, StringBuilder sb)
        {
            

            foreach (var word in wordsDictionary)
            {
                string startWord = word.Key;
                string mirrorWord = string.Empty;
                foreach (var item in startWord)
                {
                    mirrorWord = item + mirrorWord;
                }
                if (word.Value == mirrorWord)
                {
                    sb.Append($"{word.Key} <=> {word.Value}, ");
                }
            }

            return sb.ToString();
        }

        public static void PrintCorrectResult(Dictionary<string, string> wordsDictionary, StringBuilder sb) 
        {
            
            Console.WriteLine($"{wordsDictionary.Count} word pairs found!");

        }
    }
   
}