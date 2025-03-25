namespace ShoppingSystem
{
    public class Cosmetic : Product
    {
        public string Color { get; set; }

        public Cosmetic(string name, double price, int stockQuantity, string color)
            : base(name, price, stockQuantity)
        {
            Color = color;
        }

        public void DisplayCosmeticInfo()
        {
            DisplayProductInfo();
            Console.WriteLine($"Color: {Color}");
        }
    }
}
