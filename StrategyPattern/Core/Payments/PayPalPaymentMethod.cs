using SalesSystemPaymentsAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Core.Payments
{
    internal class PayPalPaymentMethod : IpaymentMethod
    {
        public Payment Charge(int customerId, double amount)
        {
            return new Payment
            {
                CustomerId = customerId,
                ChargAmount = amount + amount * 0.05,
                ReferenceNumber = Guid.NewGuid()
            };
        }
    }
}
