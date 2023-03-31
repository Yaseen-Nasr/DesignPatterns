namespace StrategyPattern.DiscountStratieges
{
    internal class GoldCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice >= 10000 ? .1 : 0; 
        }
    }
}
