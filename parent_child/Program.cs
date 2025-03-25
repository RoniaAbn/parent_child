using System;
using ShoppingSystem; // Make sure your classes use this namespace

class Program
{
    static void Main(string[] args)
    {
        // Create a basic product
        Product genericProduct = new Product("Generic Item", 19.99, 50);
        genericProduct.DisplayProductInfo();

        Console.WriteLine(); // Line break for clarity

        // Create a furniture item
        Furniture chair = new Furniture("Office Chair", 89.99, 20, "Black");
        chair.DisplayFurnitureInfo();

        Console.WriteLine();

        // Create a table item
        Table diningTable = new Table("Dining Table", 249.99, 10, "Brown", "Large");
        diningTable.DisplayTableInfo();

        Console.WriteLine();

        
    }
}

