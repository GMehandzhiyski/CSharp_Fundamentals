using System.Net.Http.Headers;
using System.Xml.Linq;
using static _05.ShoppingSpree.Person;

namespace _05.ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> personInput = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> productInput = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<Person> allPersons = new List<Person>();
            List<Product> allProducts = new List<Product>();

            AddPerson(personInput, allPersons);
            AddProduct(productInput, allProducts);

            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "End")
            {
                string[] argumet = arguments
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = argumet[0];
                string product = argumet[1];

                Person currPerson = allPersons.Where(p => p.Name == name).FirstOrDefault();
                Product currProduct = allProducts.Where(p => p.ProductName == product).FirstOrDefault();

                if (currPerson.Money > currProduct.Coast)
                {
                    currPerson.Money -= currProduct.Coast;
                    currPerson.AddProducts(currProduct);
                    Console.WriteLine($"{currPerson.Name} bought {product}");
                }
                else 
                {
                    Console.WriteLine($"{currPerson.Name} can't afford {product}");
                }

            }

            PrintAllPerson(allPersons);
        }

        private static void PrintAllPerson(List<Person> allPersons)
        {
            string printProduct = string.Empty;
            foreach (var currPerson in allPersons)
            {
                if (currPerson.Products.Count > 0)
                {
                    foreach (Product currProduct in currPerson.Products)
                    {
                        printProduct += currProduct;
                    }

                }
                else
                {
                    Console.WriteLine($"{currPerson.Name} - Nothing bought");
                }

                Console.WriteLine($"{currPerson.Name} - {printProduct.TrimEnd(',')}");
            }
        }

        private static void AddProduct(List<string> productInput, List<Product> allProduct)
        {
            foreach (var currProduct in productInput)
            {
                string[] products = currProduct
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string productName = products[0];
                decimal coast = decimal.Parse(products[1]);

                Product product = new Product(productName, coast);
                allProduct.Add(product);
            }
        }

        private static void AddPerson(List<string> personInput, List<Person> allPersons)
        {
            foreach (var currPerson in personInput)
            {
                string[] persons = currPerson
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string Name = persons[0];
                decimal Money = decimal.Parse(persons[1]);

                Person person = new Person(Name, Money);
                allPersons.Add(person);
            }
        }
    }
    public class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }
        public string Name { get; set; }

        public decimal Money { get; set; }
        public List<Product> Products;

        public void AddProducts(Product product)
        {
            Products.Add(product);
        }

        public class Product
        {
            public Product(string productName, decimal coast)
            {
                ProductName = productName;
                Coast = coast;
            }

            public string ProductName { get; set; }

            public decimal Coast { get; set; }
        }

    }
}