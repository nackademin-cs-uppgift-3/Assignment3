using Assignment3.ConsoleApp.Products.Services;

namespace Assignment3.ConsoleApp.Products.Dialog;

public class ProductDialog(IProductService productService) : IProductDialog
{
    public void AddProductDialog()
    {
        Console.Clear();
        Console.WriteLine("### ADD PRODUCT ###");

        InputDialog("Enter product name", out string name);
        InputDialog("Enter product price", out string price);

        var product = productService.AddProduct(name, price);

        if (product is not null)
            Console.WriteLine($"Product '{product.Name}' was created.");
        else
            Console.WriteLine("Unable to create new product.");

        Console.ReadKey();
    }

    public void ShowAllProductsDialog()
    {
        Console.Clear();
        Console.WriteLine("### PRODUCT LIST ###");

        var products = productService.GetAllProducts();

        foreach (var product in products)
            Console.WriteLine($"{product.Name} <{product.Pris}>");

        Console.ReadKey();
    }

    private static void InputDialog(string text, out string value)
    {
        do
        {
            Console.Write($"{text}: ");
            value = Console.ReadLine() ?? string.Empty;

            Console.Clear();
        }
        while (string.IsNullOrWhiteSpace(value));
    }
}