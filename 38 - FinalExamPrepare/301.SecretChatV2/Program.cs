using System.Globalization;
using System.Linq;
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
            int count = 0;
            string messege = Console.ReadLine();
           

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
                    messege = InsertSpace(index, messege);

                }
                else if (command == "Reverse")
                {
                    string subString = commands[1];
                    bool isSubstringIsAvalicable = IsSubstringIsAvalivable(subString, messege);
                    if (isSubstringIsAvalicable)
                    {
                        messege = SubStringManipulation(subString, messege);
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                }
                else if (command == "ChangeAll")
                {
                    string subString = commands[1];
                    string replacement = commands[2];
                    messege = ReplaceOldStringWhitNew(subString, replacement, messege);
                }
                else
                {
                    continue;
                }
                Console.WriteLine(messege);
            }
           
            Console.WriteLine($"You have a new text message: {messege}");
        }

        private static string ReplaceOldStringWhitNew(string subString, string replacement, string messege)
        {
            return messege.Replace(subString, replacement);
        }

        private static string SubStringManipulation(string subString, string messege)
        {
            int index = messege.IndexOf(subString);
            int subStringLenght = subString.Length;
            messege = messege.Remove(index, subStringLenght);
            string temporarySubString = string.Empty;

            foreach (var currChar in subString)
            {
                string currString = currChar.ToString();
                temporarySubString = temporarySubString.Insert(0, currString);
            }

           return messege += (temporarySubString);
        }

        private static bool IsSubstringIsAvalivable(string subString, string messege)
        {
            return messege.Contains(subString);
        }

        private static string InsertSpace(int index, string messege)
        {
            return messege.Insert(index, " ");
        }
    }
}
