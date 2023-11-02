using _202.Oldest_Family_Member;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
/*
5
Steve 10
Christopher 15 
Annie 4
John 35
Maria 34 
 */

namespace _202.Oldest_Family_Member
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberPeople; i++)
            {
                string[] argument = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = argument[0];
                int age = int.Parse(argument[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

           Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
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

        public void AddMember(Person person)
        { 
            Persons.Add(person);
        }
        
        public Person GetOldestMember()
        {
            int maxPersonAge = 0;
            Person oldestPerson = null;

            foreach (Person person in Persons)
            {
                if (person.Age > maxPersonAge)
                {
                   maxPersonAge = person.Age;
                   oldestPerson = person;

                }

            }
            return oldestPerson;
        }

    }
}

