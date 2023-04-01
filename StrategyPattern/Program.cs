using StrategyPattern;
using StrategyPattern.Core;
using StrategyPattern.DiscountStratieges;
using System.Diagnostics;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();
while (true)
{
    Console.WriteLine("Customer list:: [1] Mohamed Ahmed ,[2] Ibrahim Mohamed ");
    Console.Write("Enter Customer ID: ");
    int customerId = int.Parse(Console.ReadLine()!);
    Console.Write("Enter Quantity: ");
    double quantity = double.Parse(Console.ReadLine()!);
    Console.Write("Enter Unit Price: ");
    double UnitPrice = double.Parse(Console.ReadLine()!);
    //assume happy path without any validation 
    var customer = customers.First(x => x.Id == customerId);
    //Using sample factory pattern
    ICustomerDiscountStrategy discountStrategy =new CustomerDiscountStrategyFactory()
                                        .CreateCustomerDiscountStrategy(customer.CustomerCategory);
        

    var invoiceManager = new InvoiceManager();
    invoiceManager.SetDiscountStrategy(discountStrategy);
    Invoice invoice = invoiceManager.CreateInvoice(customer, quantity, UnitPrice);
     
    Console.WriteLine($"Invoice created for customer `{customer.Name}` with net price: {invoice.NetPrice}");
}