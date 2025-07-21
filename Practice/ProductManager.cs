namespace Practice;

public class Product
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class ProductManager
{
    private static readonly List<Product> s_products = new();

    private static void Add()
    {
        var product = new Product();
        Console.WriteLine("Enter product name:");
        product.Name = Console.ReadLine();
        Console.WriteLine("Enter product price:");
        if (decimal.TryParse(Console.ReadLine(), out var price)) product.Price = price;
        Console.WriteLine("Enter quantity:");
        if (int.TryParse(Console.ReadLine(), out var quantity)) product.Quantity = quantity;
        s_products.Add(product);
    }

    private static void Remove()
    {
        ViewAllProducts();
        Console.WriteLine("Enter product number to remove:");

        if (int.TryParse(Console.ReadLine(), out var index) &&
            index > 0 && index <= s_products.Count)
        {
            var removedName = s_products[index - 1].Name;
            s_products.RemoveAt(index - 1);
            Console.WriteLine($"{removedName} has been removed.");
        }
        else
        {
            Console.WriteLine("Invalid product number.");
        }
    }

    private static void Update()
    {
        ViewAllProducts();
        Console.WriteLine("Enter product number to update:");

        if (int.TryParse(Console.ReadLine(), out var index) &&
            index > 0 && index <= s_products.Count)
        {
            var product = s_products[index - 1];

            Console.WriteLine("Enter new name:");
            product.Name = Console.ReadLine();

            Console.WriteLine("Enter new price:");
            if (decimal.TryParse(Console.ReadLine(), out var newPrice))
                product.Price = newPrice;

            Console.WriteLine("Enter new quantity:");
            if (int.TryParse(Console.ReadLine(), out var newQty))
                product.Quantity = newQty;

            Console.WriteLine("Product updated!");
        }
        else
        {
            Console.WriteLine("Invalid product number.");
        }
    }

    private static void ViewAllProducts()
    {
        if (s_products.Count == 0)
        {
            Console.WriteLine("No products found");
            return;
        }

        for (var i = 0; i < s_products.Count; i++)
            Console.WriteLine($"{i + 1}. {s_products[i].Name} ${s_products[i].Price} {s_products[i].Quantity}");
    }

    public void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("Product Manager");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. View Products");
            Console.WriteLine("5. Exit");
            var choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Remove();
                    break;
                case "3":
                    Update();
                    break;
                case "4":
                    ViewAllProducts();
                    break;
                case "5": return;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}