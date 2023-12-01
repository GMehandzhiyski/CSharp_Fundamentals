namespace _601.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string argumets = string.Empty;
            while ((argumets = Console.ReadLine()) != "Decode")
            {
                string[] commands = argumets
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];

                if (command == "Move")
                {
                    int numberOfLetters = int.Parse(commands[1]);
                    message = MoveChar(message, numberOfLetters);

                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string value = commands[2];
                    message = message.Insert(index,value);
                }
                else if (command == "ChangeAll")
                {
                    string oldString = commands[1];
                    string newString = commands[2];
                    message = message.Replace(oldString, newString);
                }
                else 
                {
                    continue;
                }
            }

            Console.WriteLine($"The decrypted message is: { message}");
        }

        private static string MoveChar(string message, int numberOfLetters)
        {
            
            for (int i = 0; i < numberOfLetters; i++)
            {
               string temporary = message.Substring(0,1);
               message = message.Remove(0,1);
               message = message + temporary;
            }

            return message;
        }
    }
}