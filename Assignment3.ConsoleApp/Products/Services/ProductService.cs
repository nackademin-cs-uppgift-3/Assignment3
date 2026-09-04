using Assignment3.ConsoleApp.Products.Models;

namespace Assignment3.ConsoleApp.Products.Services;

public class ProductService : IProductService
{
    private readonly List<Product> _productList = [];

    public Product AddProduct(string name, string price)
    {
        Product product = CreateProduct(name, price);

        _productList.Add(product);

        return product;
    }

    public IReadOnlyList<Product> GetAllProducts()
    {
        return _productList
            .OrderBy(product => product.Name)
            .ToList();
    }

    private static Product CreateProduct(string name, string price)
        => new()
        {
            Name = name.Trim(),
            Pris = price.Trim()
        };
}