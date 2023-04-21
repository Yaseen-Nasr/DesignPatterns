using SalesPattern.Core.ShopingCarts;
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
            Console.WriteLine("Customer list:");
            foreach (var customer in customers)
                Console.WriteLine($"\t{customer.Id}. {customer.Name} ({customer.CustomerCategory})");

            Console.WriteLine("Item list:");
            foreach (var item in items)
                Console.WriteLine($"\t{item.Id}. {item.Name} ({item.UnitPrice})");
            Console.WriteLine();
            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine()!);

            Console.Write("select shoping cart type:(Online|InStore): ");
            ShopingCart shopingCart = Console.ReadLine()!.Equals("Online", StringComparison.OrdinalIgnoreCase) ?
                                                                new OnlineShopingCart() : new InStoreShopingCart(); 
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
            shopingCart.CheckOut(SelectedCustomer);
            Console.WriteLine("Press any key to create aonother invoice");
            Console.ReadKey();
            Console.WriteLine("---------------------------");
        }
    }
}