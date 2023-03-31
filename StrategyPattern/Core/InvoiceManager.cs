using StrategyPattern.DiscountStratieges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core
{
    internal class InvoiceManager
    {
        private ICustomerDiscountStrategy _customerDiscountStrategy;
        public void SetDiscountStrategy(ICustomerDiscountStrategy customerDiscountStrategy)
        {
            _customerDiscountStrategy = customerDiscountStrategy;
        }
        public Invoice CreateInvoice(Customer customer, double quantity, double UnitPrice)
        { 
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new[]
                {
                     new InvoiceLine
                     {
                          Quantity=quantity,UnitPrice=UnitPrice,
                     }
                }
            };
            invoice.DiscountPrecentage = _customerDiscountStrategy.CalculateDiscount(invoice.TotalPrice);
            return invoice;
        }
    }
}
