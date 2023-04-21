using StrategyPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPattern.Core.ShopingCarts
{
    internal abstract class ShopingCart
    {
        private List<InvoiceLine> _lines = new();
        public void AddItem(int itemId, double quantity, double unitPrice)
        {
            _lines.Add(new InvoiceLine { ItemId = itemId, Quantity = quantity, UnitPrice = unitPrice });
        }
        public void CheckOut(Customer customer)
        {
            var invoice = new Invoice()
            {
                Customer = customer,
                Lines = _lines
            };
            ApplyTaxes(invoice);
            ApplyDiscount(invoice);
            ProcessPayment(invoice);

        }

        private void ApplyTaxes(Invoice invoice)
        {
            invoice.Taxes =invoice.TotalPrice * 0.15;
        }

        //Templete Method
        protected abstract void ApplyDiscount(Invoice invoice);

        private void ProcessPayment(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"({GetType().Name}) Invoice created for customer `{invoice.Customer.Name}` with price: {invoice.NetPrice}");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
    internal class OnlineShopingCart : ShopingCart
    {
        protected override void ApplyDiscount(Invoice invoice)
        {
            if (invoice.TotalPrice >= 10000) invoice.DiscountPrecentage = 0.05;
        }
    }
    internal class InStoreShopingCart : ShopingCart
    {
        protected override void ApplyDiscount(Invoice invoice)
        { 
        }
    }
}
