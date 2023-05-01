﻿namespace SalesSystemPaymentsAbstraction
{
    public abstract class PaymentProcessor
    {
        public Payment ProcessPayment(int customerId,double amount)
        {
            var paymentMethod = CreatePaymentMethod();
            var payment = paymentMethod.Charge(customerId, amount);
            return payment; 
        }

        protected abstract IpaymentMethod CreatePaymentMethod();
    }
}