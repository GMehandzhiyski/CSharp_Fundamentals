using System.Diagnostics;
using System.Reflection;

namespace _202.Oldest_Family_Member
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
           
            List <Family> familyList = new List<Family>();

            for (int i = 0; i < numberPeople; i++)
            {
                string[] argument = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = argument[0];
                int age = int.Parse(argument[1]);

                Person person = new Person(name, age);
                //?????????????????????????????????(person);


                FindOldestMember(familyList);
            }


        }
        private static void FindOldestMember(List <Family> familyList)
        {
            int maxPersonAge = 0;
            string personName = string.Empty;
            foreach (Family findAge in familyList)
            {
                foreach (Person person in findAge.Persons)
                {
                    if (person.Age > maxPersonAge)
                    {
                        maxPersonAge = person.Age;
                        personName = person.Name;
                    }

                }
            }

            Console.WriteLine($"{personName} {maxPersonAge}");

        }
    }

    class Person
    {


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
    class Family
    {
        public Family()
        {
            Persons = new List<Person>();
        }
        public List<Person> Persons { get; set; }

    }
}
