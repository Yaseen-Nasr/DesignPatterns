using StrategyPattern;
using StrategyPattern.Core;
using StrategyPattern.DiscountStratieges;
using System.Diagnostics;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();
while (true)
{
    foreach (var customer in customers)
    {
        Console.WriteLine($"Customer list:: {customer.Id}. {customer.Name} ({customer.CustomerCategory})");
    }
    Console.Write("Enter Customer ID: ");
    int customerId = int.Parse(Console.ReadLine()!);
    Console.Write("Enter Quantity: ");
    double quantity = double.Parse(Console.ReadLine()!);
    Console.Write("Enter Unit Price: ");
    double UnitPrice = double.Parse(Console.ReadLine()!);
    //assume happy path without any validation 
    
    var SelectedCustomer = customers.First(x => x.Id == customerId); 
    //Using simple factory pattern to create instance
    ICustomerDiscountStrategy discountStrategy =new CustomerDiscountStrategyFactory()
                                        .CreateCustomerDiscountStrategy(SelectedCustomer.CustomerCategory);
     
    var invoiceManager = new InvoiceManager();
    invoiceManager.SetDiscountStrategy(discountStrategy);
    Invoice invoice = invoiceManager.CreateInvoice(SelectedCustomer, quantity, UnitPrice);
     
    Console.WriteLine($"Invoice created for customer `{SelectedCustomer.Name}` with net price: {invoice.NetPrice}");
}