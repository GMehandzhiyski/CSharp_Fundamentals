namespace _22.ObjectsAndClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sparky",10);
            dog.Bark();

            Dog dog2 = new Dog("John",11);
            dog.Bark();
            
        }
    }

    public class  Dog
    {
        public Dog(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public string Name {  get; set; }   

        public int Age { get; set; }

        public void Bark()
        {
            Console.WriteLine($"My  name is {Name} and I am {Age} old, bark!!");
        
        }

    }
}