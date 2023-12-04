using System.Reflection;

namespace Problem_3
{
/*
10
Add=Berg=9=0
Add=Kevin=0=0
Message=Berg=Kevin
Add=Mark=5=4
Statistics


20
Add=Mark=3=9
Add=Berry=5=5
Add=Clark=4=0
Empty=Berry
Add=Blake=9=3
Add=Michael=3=9
Add=Amy=9=9
Message=Blake=Amy
Message=Michael=Amy
Statistics

*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMessegesLimit = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            string argumnets = string.Empty;
            while ((argumnets = Console.ReadLine()) != "Statistics")
            {
                string[] commands = argumnets
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commands[0] == "Add")
                {
                    string userName = commands[1];
                    int sent = int.Parse(commands[2]);
                    int received = int.Parse(commands[3]);

                    Person person = new Person(userName, sent, received);

                    bool isPersonIsAvaliavable = CheckPerson(persons, userName);
                    if (!isPersonIsAvaliavable)
                    {
                        persons.Add(person);
                    }

                }
                else if (commands[0] == "Message")
                {
                    string sender = commands[1];
                    string reciver = (commands[2]);
                    bool isSenderIsAvaliavable = CheckPerson(persons, sender);
                    bool isReciverIsAvaliavable = CheckPerson(persons, reciver);
                    if (isSenderIsAvaliavable
                        && isReciverIsAvaliavable)
                    {
                        IncreseSent(persons, sender, numberMessegesLimit);
                        IncreseReceive(persons, reciver, numberMessegesLimit);
                    }


                }
                else if (commands[0] == "Empty")
                {
                    string userName = commands[1];
                    if (userName == "All")
                    {
                        persons.Clear();
                    }
                    else
                    {
                        bool isPersonIsAvaliavable = CheckPerson(persons, userName);
                        if (isPersonIsAvaliavable)
                        {
                            DeleteUser(persons, userName);
                        }
                        
                    }
                    

                }

            }
            PrintFinalResult(persons);
        }

        private static void PrintFinalResult(List<Person> persons)
        {
            Console.WriteLine($"Users count: {persons.Count}");
            foreach (var currPerson in persons)
            {
                Console.WriteLine($"{currPerson.UserName} - {currPerson.Sent + currPerson.Received}");
            }
            Console.WriteLine();
        }

        private static void DeleteUser(List<Person> persons, string userName)
        {
            foreach (var currPerson in persons)
            {
                if (currPerson.UserName == userName)
                {
                    persons.Remove(currPerson);
                    return;
                }
            }
        }

        private static void IncreseReceive(List<Person> persons, string reciver, int numberMessegesLimit)
        {
            foreach (var currPerson in persons)
            {
                if (currPerson.UserName == reciver)
                {
                    currPerson.Received += 1;
                    if (currPerson.Received + currPerson.Sent >= numberMessegesLimit)
                    {
                        Console.WriteLine($"{currPerson.UserName} reached the capacity!");
                        persons.Remove(currPerson);
                        return;

                    }
                }
            }
        }

        private static void IncreseSent(List<Person> persons, string sender,int numberMessegesLimit)
        {
            foreach (var currPerson in persons)
            {
                if (currPerson.UserName == sender)
                {
                    currPerson.Sent += 1;
                    if (currPerson.Sent + currPerson.Received >= numberMessegesLimit)
                    {
                        Console.WriteLine($"{currPerson.UserName} reached the capacity!");
                        persons.Remove(currPerson);
                        return;

                    }
                }
            }
        }

        private static bool CheckPerson(List<Person> persons, string userName)
        {
            bool isPersonIsAvaliavable = false;
            foreach (var currPerson in persons)
            {
                if (currPerson.UserName == userName)
                {
                    return isPersonIsAvaliavable = true;
                }
            }
            return isPersonIsAvaliavable;
        }
    }
    public class Person
    {


        public Person(string userName, int sent, int received)
        {
            UserName = userName;
            Sent = sent;
            Received = received;
        }

        public string UserName { get; set; }
        public int Sent { get; set; }
        public int Received { get; set; }
       
    }
}