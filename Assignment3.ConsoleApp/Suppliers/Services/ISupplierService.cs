using Assignment3.ConsoleApp.Suppliers.Models;

namespace Assignment3.ConsoleApp.Suppliers.Services;

internal interface ISupplierService
{
    Supplier AddSupplier(string supplierName, string supplierEmail, string? supplierPhoneNumer);
    IReadOnlyList<Supplier> GetAllSuppliers();
}
