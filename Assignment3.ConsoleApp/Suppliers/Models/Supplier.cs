namespace Assignment3.ConsoleApp.Suppliers.Models;

public class Supplier(Guid id, string supplierName, string supplierEmail, string? supplierPhoneNumer)
{
    public Guid Id { get; init; } = id;
    public string SupplierName { get; set; } = supplierName;
    public string SupplierEmail { get; set; } = supplierEmail;
    public string? SupplierPhoneNumber { get; set; } = supplierPhoneNumer;
}
