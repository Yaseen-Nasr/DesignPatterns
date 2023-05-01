using SalesSystemPaymentsAbstraction;

namespace SalesSystem.Core.Payments
{
    internal class PayPalPaymentProcessor : PaymentProcessor
    {
        protected override IpaymentMethod CreatePaymentMethod()
        {
            return new PayPalPaymentMethod();
        }
    }
}
