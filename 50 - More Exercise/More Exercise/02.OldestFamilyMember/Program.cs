using System.Xml.Linq;

namespace _02.OldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < numberPeople; i++)
            {
                
                string[] people = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                string name = people[0];
                int age = int.Parse(people[1]);

                Person person = new Person(name, age);
              

                family.AddMember(person);
            }
            Person OldestPerson = family.GetOldestMember();
            Console.WriteLine($"{OldestPerson.Name} {OldestPerson.Age}");
        }
    }
    public class Family
    {
        public Family()
        {
            Persons = new List<Person>();
        }

        public void AddMember(Person person)
        { 
             Persons.Add(person);
        }

        public Person GetOldestMember()
        { 
            Person oldestHuman = Persons.MaxBy(p => p.Age);
            return oldestHuman;
        }
      public List<Person> Persons { get; set; }
    }
    public class Person
    {
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

   
}