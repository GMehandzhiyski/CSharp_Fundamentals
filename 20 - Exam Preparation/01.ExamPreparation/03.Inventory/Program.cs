namespace _03.Inventory
{
/*
Iron, Wood, Sword
Combine Items - Sword:Bow
     */

    internal class Program
    {
        static void Main(string[] args)
        {
           List <string> inpitList = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string arguments;
            while ((arguments = Console.ReadLine()) != "Craft!") 
            {
                string[] command = arguments.Split(" - ");

                if (command[0] == "Collect")
                {
                    string item = command[1];
                    int isFoundIndex = inpitList.IndexOf(item);
                    if (isFoundIndex == -1)
                    {
                        inpitList.Add(item);
                    }

                }
                else if (command[0] == "Drop")
                {
                    string item = command[1];
                    int isFoundIndex = inpitList.IndexOf(item);
                    if (isFoundIndex != -1)
                    {
                        inpitList.RemoveAt(isFoundIndex);
                    }
                }
                else if (command[0] == "Combine Items")
                {
                    string[] itemString = command[1].ToString().Split(":");   
                    string oldItem = itemString[0];
                    string newItem = itemString[1];
                    int isFoundIndex = inpitList.IndexOf(oldItem);

                    if (isFoundIndex != -1)
                    {
                        inpitList.Insert(isFoundIndex + 1, newItem);
                    }
                }
                else if (command[0] == "Renew")
                {
                    string item = command[1];
                    int isFoundIndex = inpitList.IndexOf(item);

                    if (isFoundIndex != -1)
                    {
                       string safeValue =  inpitList[isFoundIndex];
                        inpitList.RemoveAt(isFoundIndex);
                        inpitList.Add(safeValue);
                    }
                }


            }

            Console.WriteLine(string.Join(", ", inpitList));
        }
    }
}