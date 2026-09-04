using Assignment3.ConsoleApp.Suppliers.Models;
using Assignment3.ConsoleApp.Suppliers.Services;

namespace Assignment3.ConsoleApp.Suppliers.Dialogs;

internal class SupplierDialogService(ISupplierService supplierService) : ISupplierDialog
{
    public void AddSupplierDialog()
    {
        Console.Clear();
        Console.WriteLine("ADD SUPPLIER");
        Console.WriteLine();

        string supplierName = InputDialog("Enter the name of the supplier");
        string supplierEmail = InputDialog("Enter the email of the supplier");
        string? supplierPhoneNumber = GetPhoneNumber();

        Supplier supplier = supplierService.AddSupplier(supplierName, supplierEmail, supplierPhoneNumber);

        if (supplier is not null)
        {
            Console.WriteLine($"A new supplier '{supplier.SupplierName}' with the id <{supplier.Id}> was created.");
        }
        else
        {
            Console.WriteLine("Unable to create a new supplier");
        }
    }

    private string InputDialog(string text)
    {
        string value = string.Empty;

        do
        {
            Console.Write($"{text}: ");

            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine();
                Console.Write("Invalid input, try again! Press enter to continue.");
                Console.ReadKey();
            }

            Console.Clear();
        }
        while (string.IsNullOrWhiteSpace(value));

        return value;
    }

    private string? GetPhoneNumber()
    {
        Console.Write("Enter the phone number of the supplier (optional): ");
        string? supplierPhoneNumber = Console.ReadLine();

        return supplierPhoneNumber;
    }

    public void ShowAllSuppliersDialog()
    {
        throw new NotImplementedException();
    }
}
