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

            StringBuilder sb = new StringBuilder();
            sb.Append(inputString);

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Travel")
            {
                string[] command = arguments
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    bool isIndexIsValid = CheckForValidIndex(index, sb);
                    if (isIndexIsValid)
                    {
                        string destination = command[2];
                        sb.Insert(index, destination);
                    }
                    Console.WriteLine(sb.ToString());
                }

                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    bool isIndexsIsValid = CheckForValidIndexs(startIndex, endIndex, sb);
                    if (isIndexsIsValid)
                    {
                        sb.Remove(startIndex, (endIndex - startIndex) + 1);
                    }
                    Console.WriteLine(sb.ToString());
                }
                else if (command[0] == "Switch")
                {
                    string oldIndex = command[1];
                    string newIndex = command[2];
                    bool isOldIndexIsAvalivable = CheckOldIndex(oldIndex, sb);
                    if (isOldIndexIsAvalivable)
                    {
                        sb.Replace(oldIndex, newIndex);
                    }
                    Console.WriteLine(sb.ToString());
                }
                else
                {
                    continue;
                }
               
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {sb.ToString()}");
        }

        private static bool CheckOldIndex(string oldIndex, StringBuilder sb)
        {
            bool containsResult;
            return containsResult = sb.ToString().Contains(oldIndex);
        }

        private static bool CheckForValidIndexs(int startIndex, int endIndex, StringBuilder sb)
        {
            return (startIndex >= 0 && startIndex < sb.Length)
                    && (endIndex < sb.Length);
        }

        private static bool CheckForValidIndex(int index, StringBuilder sb)
        {
            return index >= 0 && index <= sb.Length;
        }
    }
}