using Assignment3.ConsoleApp.Customers.Models;

namespace Assignment3.ConsoleApp.Customers.Services
{
    public interface ICustomerService
    {
        void AddCustomer(string name, string email);
    }
}