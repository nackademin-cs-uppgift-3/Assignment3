using Assignment3.ConsoleApp.Suppliers.Models;

namespace Assignment3.ConsoleApp.Suppliers.Services;

internal class SupplierService : ISupplierService
{
    private readonly List<Supplier> _supplierList = [];

    public Supplier AddSupplier(Guid id, string supplierName, string supplierEmail, string? supplierPhoneNumer)
    {
        Supplier supplier = CreateSupplier(supplierName, supplierEmail, supplierPhoneNumer);

        _supplierList.Add(supplier);

        return supplier;
    }

    private Supplier CreateSupplier(string supplierName, string supplierEmail, string? supplierPhoneNumer)
    {
        return new Supplier(Guid.NewGuid(), supplierName, supplierEmail, supplierPhoneNumer);
    }

    public IReadOnlyList<Supplier> GetAllSuppliers()
    {
        return _supplierList
            .OrderBy(supplier => supplier.SupplierName)
            .ToList();
    }
}
