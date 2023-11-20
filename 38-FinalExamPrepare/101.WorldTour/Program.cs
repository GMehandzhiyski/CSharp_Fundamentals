using System;
using System.Reflection;
using System.Text;

namespace _101.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Travel")
            {
                string[] commands = arguments
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                    
                string command = commands[0];
                if (command == "Add Stop")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 
                        && index < inputString.Length)
                    {
                        string destination = commands[2];
                        inputString = inputString.Insert(index, destination);
                    }
                }

                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex >= 0 
                        && endIndex < inputString.Length)
                    {
                        inputString = inputString.Remove(startIndex, (endIndex - startIndex) + 1);
                    }

                }
                else if (command == "Switch")
                {
                    string oldIndex = commands[1];
                    string newIndex = commands[2];
                   
                    if (inputString.Contains(oldIndex))
                    {
                        inputString = inputString.Replace(oldIndex, newIndex);
                    }

                }
              
                Console.WriteLine(inputString);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {inputString}");
        }

   
       
    }
}