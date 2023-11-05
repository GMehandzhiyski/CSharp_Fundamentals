namespace _04.SoftUniParking
{
/*
5
register John CS1234JS
register George JAVA123S
register Andy AB4142CD
register Jesica VR1223EE
unregister Andy
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCommand = int.Parse(Console.ReadLine());

            Dictionary <string, string> customersDateBase = new Dictionary<string, string>();

            for (int i = 0; i < numberCommand; i++)
            {
                string[] argumnets = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = argumnets[0];
                string customerName = argumnets[1];

                if (command == "register")
                {
                    
                    string licensePlate = argumnets[2];

                    if (!customersDateBase.ContainsKey(customerName))
                    {
                        customersDateBase.Add(customerName, licensePlate);
                        Console.WriteLine($"{customerName} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                   
                }
                else if (command == "unregister")
                {
                    if (customersDateBase.ContainsKey(customerName))
                    {
                        bool deleteKey = customersDateBase.Remove(customerName);
                        if (deleteKey) 
                        {
                            Console.WriteLine($"{customerName} unregistered successfully");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {customerName} not found");
                    }
                
                }
                else
                {
                    continue;
                }
            }

            foreach (KeyValuePair <string,string> currCustomer in customersDateBase)
            {
                Console.WriteLine($"{currCustomer.Key} => {currCustomer.Value}");
            }
        }
    }
}