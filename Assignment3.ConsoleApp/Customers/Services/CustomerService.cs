using Assignment3.ConsoleApp.Customers.Models;

namespace Assignment3.ConsoleApp.Customers.Services
{
    public class CustomerService : ICustomerService
    {   private readonly List<Customer> _customers = new();
        public void AddCustomer(string name, string email)
        { 
        
            var customer = new Customer(name, email);
            _customers.Add(customer);
           
        }
    }
}
