namespace ShoppingSystem
{
    public class Table : Furniture
    {
        public string Size { get; set; }

        public Table(string name, double price, int stockQuantity, string color, string size)
            : base(name, price, stockQuantity, color)
        {
            Size = size;
        }

        public void DisplayTableInfo()
        {
            DisplayFurnitureInfo();
            Console.WriteLine($"Size: {Size}");
        }
    }
}
