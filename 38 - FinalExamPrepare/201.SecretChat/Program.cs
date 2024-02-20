using System.Globalization;
using System.Security;
using System.Text;
/*
heVVodar!gniV
ChangeAll:|:V:|:l
Reverse:|:!gnil
InsertSpace:|:5
Reveal
*/
namespace _201.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine(message);

            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "Reveal")
            {
                string[] commands = argumets
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(commands[1]);
                    InsertSpace(index, sb);

                }
                else if (command == "Reverse")
                {
                    string subString = commands[1];
                    bool isSubstringIsAvalicable = IsSubstringIsAvalivable(subString, sb);
                    if (isSubstringIsAvalicable)
                    {
                        SubStringManipulation(subString, sb);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (command == "ChangeAll")
                {
                    string subString = commands[1];
                    string replacement = commands[2];
                    ReplaceOldStringWhitNew(subString, replacement, sb);
                }
                else
                {
                    continue;
                }

               sb.Replace('\0', ' ');
               Console.WriteLine(sb.ToString().TrimEnd(' '));

            }
            sb.Replace('\0', ' ');
            Console.WriteLine($"You have a new text message: {sb.ToString()}");
        }

        private static void ReplaceOldStringWhitNew(string subString, string replacement, StringBuilder sb)
        {
           sb = sb.Replace(subString, replacement);
        }

        private static void SubStringManipulation(string subString, StringBuilder sb)
        {
            int index = sb.ToString().IndexOf(subString);
            int subStringLenght = subString.Length;
            sb = sb.Remove(index, subStringLenght);
            string temporarySubString = string.Empty;

            foreach (var currChar in subString)
            {
                string currString = currChar.ToString();
                temporarySubString = temporarySubString.Insert(0, currString);
            }

            sb.Append(temporarySubString);


        }

        private static bool IsSubstringIsAvalivable(string subString, StringBuilder sb)
        {
            return sb.ToString().Contains(subString);
        }

        private static void InsertSpace(int index, StringBuilder sb)
        {
            sb = sb.Insert(index," ");
        }
    }
}