// See https://aka.ms/new-console-template for more information
using OnlineOrders.Core;
using System.Diagnostics;
using System.Drawing;

//assume happy path without any validation 

var products = new ProdectDataReder().GetProducts();


while (true)
{
    Console.WriteLine("product list:");

    foreach (var product in products)
        Console.WriteLine($"\t{product.Id}. {product.Name} ({product.UnitPrice})");
    Console.WriteLine();

    Order newOrder = new();
    Console.WriteLine($"Order State {newOrder.State}");
    while (true)
    {
        Console.Write("Enter product ID (0 to complete the order): ");
        var productId = int.Parse(Console.ReadLine()!);
        if (productId == 0) break;

        Console.Write("Enter item quantity: ");
        var quantity = double.Parse(Console.ReadLine()!);

        var product = products.First(x => x.Id == productId);

        newOrder.Lines.Add(new OrderLine() { ProductId = product.Id, Quantity = quantity, UnitPrice = product.UnitPrice });
    }
    while (true)
    {
        Console.WriteLine("Select Action:");
        Console.WriteLine("\t1. Confirm:");
        Console.WriteLine("\t2. Process:");
        Console.WriteLine("\t3. Cancele:");
        Console.WriteLine("\t4. Shipp:");
        Console.WriteLine("\t5. Deliver:");
        Console.WriteLine("\t6. Return:");
        Console.WriteLine("\t7. Exit:");
        int action = int.Parse(Console.ReadLine()!);
        try
        {
            switch (action)
            {
                case 1:
                    newOrder.Confirm();
                    break;
                case 2: newOrder.Process();
                    break;
                case 3: newOrder.Cancel();
                    break;
                case 4: newOrder.Shipp();
                    break;
                case 5: newOrder.Deliver();
                    break;
                case 6: newOrder.Return();
                    break;
                default:
                    break;
            }
           Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"Order state changed to : `{newOrder.State}`");
           Console.ForegroundColor= ConsoleColor.White;
        } 
        catch (Exception e )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Can not change Order state to ");
           Console.ForegroundColor= ConsoleColor.White;

        }
    }

}
