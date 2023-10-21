namespace _02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> productList = Console.ReadLine()
                .Split("!",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string arguments;
            while ((arguments = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commands = arguments.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Urgent")
                {
                    string item = commands[1];
                    if (productList.IndexOf(item) == -1)
                    { 
                        productList.Insert(0, item);
                    }

                }
                else if (commands[0] == "Unnecessary")
                {
                    string item = commands[1];
                    int isFoundItem = productList.IndexOf(item); // -1 not found, 
                    if (isFoundItem != -1)
                    { 
                        productList.RemoveAt(isFoundItem);
                    }


                }
                else if (commands[0] == "Correct")
                {
                    string oldItem = commands[1];
                    string newItem = commands[2];
                    int isFoundItem = productList.IndexOf(oldItem);
                    if (isFoundItem != -1)
                    {
                        productList[isFoundItem] = newItem;
                    }

                }
                else if (commands[0] == "Rearrange")
                {
                    string item = commands[1];
                    int isFoundItem = productList.IndexOf(item);
                    if (isFoundItem != -1) 
                    {
                        string saveValue = productList[isFoundItem];
                        productList.RemoveAt(isFoundItem);
                        productList.Add(saveValue);
                    
                    }
                }
                else 
                {
                    continue;
                }

            
            }
            Console.WriteLine(string.Join(", ", productList));
        }
    }
}