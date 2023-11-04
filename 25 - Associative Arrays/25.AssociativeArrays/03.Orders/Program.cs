namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, ProductInfo> productsDict = new Dictionary<string, ProductInfo> ();  

            string arguments = string.Empty;

            while ((arguments = Console.ReadLine()) != "buy") 
            {
                string[] inputArray = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string productName = inputArray[0];
                decimal productPrice = decimal.Parse(inputArray[1]);
                int productQuantity = int.Parse(inputArray[2]); 
                
                ProductInfo newProduct = new ProductInfo(productName, productPrice, productQuantity);
                
                if (!productsDict.ContainsKey(productName))
                {
                    productsDict.Add(newProduct.ProductName, newProduct); 
                }
                else 
                {
                  
                   productsDict[newProduct.ProductName].AddNewPriceAndQuantity(productPrice, productQuantity);
                }
            }

            PrintPrice(productsDict);
        }

        private static void PrintPrice(Dictionary<string, ProductInfo> productsDict)
        {
            foreach (var currProduct in productsDict)
            {
                decimal finalPrice = currProduct.Value.ProductPrice * currProduct.Value.ProductQuantity;
                Console.WriteLine($"{currProduct.Key} -> {finalPrice:f2}");
            }
        }
    }
    public class ProductInfo
    {
        public ProductInfo(string productName,  decimal productPrice, int productQuantity)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
        }

        public  string ProductName { get; set; }
        public decimal ProductPrice { get; set;}

        public int ProductQuantity { get; set; }

        public void AddNewPriceAndQuantity(decimal productPrice, int productQuantity)
        {
            ProductPrice = productPrice;
            ProductQuantity = ProductQuantity + productQuantity;

        }
    }
}
//foreach (KeyValuePair <string, ProductInfo> currenProduct in productsDict)
//{
//    Console.WriteLine(currenProduct.Key);

//    foreach (var currProductInfo in productsDict.Values)
//    {
//        Console.WriteLine(currProductInfo.ProductPrice);
//        Console.WriteLine(currProductInfo.ProductQuantity);
//    }

//}