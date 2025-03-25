namespace ShoppingSystem
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public Product(string name, double price, int stockQuantity)
        {
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}, Stock: {StockQuantity}");
        }
    }
}
