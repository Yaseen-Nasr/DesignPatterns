using SalesSystemPaymentsAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Core.Payments
{
    internal class VisaPaymentMethod : IpaymentMethod
    {
        public Payment Charge(int customerId, double amount)
        {
            var commison = amount < 10000 ? amount * 0.02 : 0;
            return new Payment
            {
                CustomerId = customerId,
                ChargAmount = amount+ commison,
                ReferenceNumber = Guid.NewGuid()
            };
        }
    }
}
