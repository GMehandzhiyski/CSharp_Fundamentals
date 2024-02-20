namespace _106.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string argumets = string.Empty;  
            while ((argumets = Console.ReadLine()) != "end") 
            {
                string[] argument = argumets
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int serialNumber = int.Parse(argument[0]);
                string name = argument[1];
                int quantity = int.Parse(argument[2]);  
                decimal price = decimal.Parse(argument[3]);
                
                Item item = new Item(name, price); 
                decimal boxPrice = quantity * price;
                Box box = new Box(serialNumber, quantity, item, boxPrice);
                boxes.Add(box);
            }

            foreach (var currBox in boxes.OrderByDescending(b => b.PriceBox))
            {
                Console.WriteLine(currBox.SerialNumber);
                Console.WriteLine($"-- {currBox.Item.Name} - ${currBox.Item.Price:f2}: {currBox.Quantity}");
                Console.WriteLine($"-- ${currBox.PriceBox:f2}");
            }
        }

      
    }
    public class Box
    {
       

        public Box(int serialNumber, int quantity, Item item, decimal boxPrice)
        {
            SerialNumber = serialNumber;
            Quantity = quantity;
            Item = item;
            PriceBox = boxPrice;
        }

        public int SerialNumber { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }
        public Item Item { get; set; }

    }
    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal  Price { get; set; }
    }
}