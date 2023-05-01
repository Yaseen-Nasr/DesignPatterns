using SalesSystemPaymentsAbstraction;

namespace SalesSystem.Core.Payments
{
    internal class VisaPaymentProcessor : PaymentProcessor
    {
        protected override IpaymentMethod CreatePaymentMethod()
        {
            return new VisaPaymentMethod();
        }
    }
}
