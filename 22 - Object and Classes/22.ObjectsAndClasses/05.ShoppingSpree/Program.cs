using System.Security.Cryptography.X509Certificates;

namespace _05.ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPersons = new List<Person>();
            List<Product> allProducts = new List<Product>();

            List<string> inputListPerson = Console.ReadLine()
                 .Split(";", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            List<string> inputListProduct = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (string inputPerson in inputListPerson)
            {

                string eachperson = inputPerson;

                List<string> personInfo = eachperson
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);
                Person person = new Person(name, money);
                allPersons.Add(person);

            }

            foreach (string inputProduct in inputListProduct)
            {
                string eachProduct = inputProduct;

                List<string> productInfo = eachProduct
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string productName = productInfo[0];
                decimal productCoast = decimal.Parse(productInfo[1]);
                Product product = new Product(productName, productCoast);
                allProducts.Add(product);
                //Person person = allPersons.Where(a => a.Name == "Peter").FirstOrDefault();Tova e samo za test na dobavqne na product v class Person
                //person.AddValueProducts(product);

            }
            string arguments = string.Empty;
            while ((arguments = Console.ReadLine()) != "END")
            {
                string[] commands = arguments.
                    Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = commands[0];
                string product = commands[1];

                Person currPerson = allPersons.Where(a => a.Name == name).FirstOrDefault();
                Product currProduct = allProducts.Where(a => a.ProductName == product).FirstOrDefault();

                if (currPerson.Money >= currProduct.ProductCost)
                {
                    currPerson.Money -= currProduct.ProductCost;
                    currPerson.AddProducts(currProduct);
                    Console.WriteLine($"{currPerson.Name} bought {currProduct.ProductName}");


                }
                else
                {
                    Console.WriteLine($"{currPerson.Name} can't afford {currProduct.ProductName}");
                }



            }

            PrintAllPersons(allPersons);


        }

        public static void PrintAllPersons(List<Person> allPersons)
        {
            foreach (Person currPerson in allPersons)
            {
                if (currPerson.Products.Count > 0)
                {
                    string allProducts = string.Empty;
                    foreach (Product currProduct in currPerson.Products)
                    {
                        allProducts = allProducts + currProduct.ProductName + ", ";
                    }
                    string finalProducts = allProducts.Substring(0, allProducts.Length - 2);
                    Console.WriteLine($"{currPerson.Name} - {finalProducts}");
                }
                else
                {
                    Console.WriteLine($"{currPerson.Name} - Nothing bought");
                }
                
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
    }

    public class Product
    {
        public Product(string productName, decimal productCost)
        {
            ProductName = productName;
            ProductCost = productCost;

        }
        public string ProductName { get; set; }
        public decimal ProductCost { get; set; }

    }

  
}