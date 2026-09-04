using Assignment3.ConsoleApp.Customers.Services;

namespace Assignment3.ConsoleApp.Customers.Dialog
{
    public class CustomerDialogService(ICustomerService customerService) : ICustomerDialog
    {
        public void AddCustomerDialog()
        {
            Console.WriteLine("Ange kundens namn:");
            string name = Console.ReadLine() ?? "";
            
            Console.WriteLine("Ange kundens email:");
            string email = Console.ReadLine() ?? "";

            customerService.AddCustomer(name, email);

            Console.WriteLine($"Kunden {name} med email {email} har lagts till.");
        }
    }
}
