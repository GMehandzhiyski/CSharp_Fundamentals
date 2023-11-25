using System.Text.RegularExpressions;

namespace _502.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexPatternEmoji = @"([:]{2}|[*]{2})(?<emoji>[A-Z][a-z]{2,})(\1)";

            string regexPatternNumber = @"(?<number>\d{1})";

            string inputString = Console.ReadLine();

            List<string> coolEmojis = new List<string>();

            MatchCollection matchesNumber = Regex.Matches(inputString, regexPatternNumber);
            int coolThreshold = 1;

            foreach (Match number in matchesNumber)
            {
                int tempTreshold = int.Parse(number.Groups["number"].Value);
                coolThreshold *= tempTreshold;
            }

            MatchCollection matchesEmoji = Regex.Matches(inputString, regexPatternEmoji);
            
            int couterEmoji = 0;
            foreach (Match emoji in matchesEmoji)
            {
                int emojiCool = 0;
                couterEmoji++;
                string emojiString = (emoji.Groups["emoji"].Value);
               
                foreach (var currChar in emojiString)
                {
                    int tempEmoji = (int)currChar;
                    emojiCool += tempEmoji;
                }

                bool isEmojiIsCool = CheckCoolEmoji(emojiCool, coolThreshold);
              
                if (isEmojiIsCool) 
                {
                    coolEmojis.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{couterEmoji} emojis found in the text. The cool ones are: ");
            foreach (var currEmoji in coolEmojis)
            {
                Console.WriteLine(currEmoji);
            }
        }

        private static bool CheckCoolEmoji(int emojiCool, int coolThreshold)
        {
            return emojiCool > coolThreshold;
        }
    }
}