using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> inputList = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
   
            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "Done")
            {
                string[] commands = arguments.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Add Book")
                {
                    string bookName = commands[1];
                    int isBookValid = inputList.IndexOf(bookName);
                    if (isBookValid == -1)
                    {
                        inputList.Insert(0, bookName);
                    }

                 
                }
                else if (commands[0] == "Take Book")
                {
                    string bookName = commands[1];
                    int isBookValid = inputList.IndexOf(bookName);
                    if (isBookValid != -1)
                    {
                        inputList.RemoveAt(isBookValid);
                    }


                }
                else if (commands[0] == "Swap Books")
                {
                    string bookName1 = commands[1];
                    string bookName2 = commands[2];
                    int isBookValid1 = inputList.IndexOf(bookName1);
                    int isBookValid2 = inputList.IndexOf(bookName2);
                    if ((isBookValid1 != -1) && (isBookValid2 != -1))
                    {
                        string saveValue1 = inputList[isBookValid1];
                        string saveValue2 = inputList[isBookValid2];
                        inputList[isBookValid1] = saveValue2;
                        inputList[isBookValid2] = saveValue1;


                    }

                }
                else if (commands[0] == "Insert Book")
                {
                    string bookName = commands[1];
                    int isBookValid = inputList.IndexOf(bookName);
                    if (isBookValid == -1)
                    {
                        inputList.Add(bookName);
                    }

                }
                else if(commands[0] == "Check Book")
                {
                    int index = int.Parse(commands[1]);
                    if ((0 <= index) && (index <= inputList.Count))
                    {
                        Console.WriteLine(inputList[index]);
                    
                    }
                      
                }

            }

            Console.WriteLine(string.Join(", ", inputList));

        }
    }
}