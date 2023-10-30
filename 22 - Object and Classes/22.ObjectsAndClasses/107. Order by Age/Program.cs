namespace _107._Order_by_Age
{
    public class Program
    {
        static void Main(string[] args)
        {
            List <People> peopleList = new List <People> ();

            string arguments;
            while ((arguments = Console.ReadLine()) != "End")
            {
                string[] inputArray = arguments
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputArray[0];
                string iD = inputArray[1];
                int age = int.Parse(inputArray[2]);

                foreach (People person in peopleList)
                {
                    if (person.Id == iD)
                    { 
                        person.Name = name;
                        person.Age = age;
                    }
                    
                }
                People people = new People(name, iD, age);
                peopleList.Add(people); 

            }

            GetPrintList(peopleList);
        }

        static void GetPrintList(List<People> peopleList)
        {
            foreach (People person in peopleList.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }

        class People
        {
            public People(string name, string iD, int age)
            {
                Name = name;
                Id = iD;
                Age = age;
            }

            public string Name { get; set; }

            public string Id { get; set; }

            public  int Age { get; set; }

        }
    }
}