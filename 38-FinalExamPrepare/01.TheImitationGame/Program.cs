using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _01.TheImitationGame
{
/*
owyouh
Move|2
Move|3
Insert|3|are
Insert|9|?
Decode
*/

    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            List<string> finalMessage = new List<string>();

            foreach (var lett in encryptedMessage)
            {
                string letters = lett.ToString();
                finalMessage.Add(letters);
            }

            string arguments = string.Empty; 
            while((arguments = Console.ReadLine()) != "Decode")
            {
                string[] command = arguments
                    .Split("|",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Move")
                {
                    int numberOfMove = int.Parse(command[1]);

                    MoveElementInFinalMessage(finalMessage, numberOfMove);
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];


                    AddElementInFinalMessage(finalMessage,index,value);
                }
                else if (command[0] == "ChangeAll")
                {
                    string oldChar = command[1];
                    string newChar = command[2];

                    ChangeLetterInList(finalMessage, oldChar,newChar);

                }
                else 
                {
                    continue;
                }
            
            }

            Console.WriteLine($"The decrypted message is: {string.Join("",finalMessage)}");

        }

        private static void MoveElementInFinalMessage(List<string> finalMessage, int numberOfMove)
        {
            for (int i = 0; i < numberOfMove; i++)
            {
                string temporaryValue = finalMessage[0];
                finalMessage.RemoveAt(0);
                finalMessage.Add(temporaryValue);
            }
        }

        private static void AddElementInFinalMessage(List<string> finalMessage, int index, string value)
        {
            if (value.Length > 1)
            {
                foreach (var lett in value)
                {
                    string letter = lett.ToString();
                    finalMessage.Insert(index, letter);
                    index++;
                }
            }
            else
            {
                finalMessage.Insert(index, value);
            }
            
        }

        private static void ChangeLetterInList(List<string> finalMessage, string oldChar, string newChar)
        {
            for (int i = 0; i < finalMessage.Count; i++)
            {
                if (finalMessage[i] == oldChar)
                {
                    finalMessage[i] = newChar;
                }
            }
        }
    }
}