namespace ShoppingSystem
{
    public class Furniture : Product
    {
        public string Color { get; set; }

        public Furniture(string name, double price, int stockQuantity, string color)
            : base(name, price, stockQuantity)
        {
            Color = color;
        }

        public void DisplayFurnitureInfo()
        {
            DisplayProductInfo();
            Console.WriteLine($"Color: {Color}");
        }
    }
}
