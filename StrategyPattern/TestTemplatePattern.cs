using SalesPattern.Core.ShopingCarts;
using SalesSystem.Core.Payments;
using SalesSystemPaymentsAbstraction;
using StrategyPattern.Core;
using StrategyPattern.DiscountStratieges;

public static class TestTemplatePattern
{
    public static void Run()
    {
        var customers = new CustomerDataReader().GetCustomers();
        var items = new ItemDataReader().GetItems();

        while (true)
        {
            int customerId = SelectCustomer();
            
             ShopingCart shopingCart = SelectShopingCart(); 
            //assume happy path without any validation 
            while (true)
            {   
                Console.Write("Enter Item ID (0 to complete the order): ");
                var itemId = int.Parse(Console.ReadLine()!);
                if (itemId == 0) break; 
                Console.Write("Enter item quantity: "); 
                var quantity = double.Parse(Console.ReadLine()!);
                var item = items.First(x => x.Id == itemId);

                shopingCart.AddItem(itemId, quantity, item.UnitPrice);
            }
            var SelectedCustomer = customers.First(x => x.Id == customerId);

            Console.Write("Select payMent method (Visa | PayPal)");
            PaymentProcessor paymentProcessor = Console.ReadLine() == "Visa" ? new VisaPaymentProcessor() : new PayPalPaymentProcessor();
            shopingCart.CheckOut(SelectedCustomer,paymentProcessor);

            Console.WriteLine("Press any key to create aonother invoice");
            Console.ReadKey();
            Console.WriteLine("---------------------------");
        }
    }

    private static int SelectCustomer()
    {
        var customers = new CustomerDataReader().GetCustomers();

        Console.WriteLine("Customer list:");
        foreach (var customer in customers)
            Console.WriteLine($"\t{customer.Id}. {customer.Name} ({customer.CustomerCategory})");
        DisplayItems();
        Console.Write("Enter Customer ID: ");
        return int.Parse(Console.ReadLine()!);
    }
    private static void DisplayItems()
    {
        var items = new ItemDataReader().GetItems();
        Console.WriteLine("Item list:");

        foreach (var item in items)
            Console.WriteLine($"\t{item.Id}. {item.Name} ({item.UnitPrice})");
        Console.WriteLine();

    }
    private static ShopingCart SelectShopingCart()
    {
        Console.Write("select shoping cart type:(Online|InStore): ");
        ShopingCart shopingCart = Console.ReadLine()!.Equals("Online", StringComparison.OrdinalIgnoreCase) ?
                                                            new OnlineShopingCart() : new InStoreShopingCart();
        return shopingCart;
    }
}