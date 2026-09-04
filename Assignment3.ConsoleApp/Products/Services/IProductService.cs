using Assignment3.ConsoleApp.Products.Models;

namespace Assignment3.ConsoleApp.Products.Services;

public interface IProductService
{
    Product AddProduct(string name, string price);
    IReadOnlyList<Product> GetAllProducts();
}