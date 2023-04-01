
namespace StrategyPattern.DiscountStratieges
{
    internal class CustomerDiscountStrategyFactory
    {
        //centralizetion creating CustomerDiscountStrategy instance and reusability 
        public ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory category)
        {
           return category switch
            {
                CustomerCategory.New => new NewCustomerDiscountStrategy(),
                CustomerCategory.Silver => new SilverCustomerDiscountStrategy(),
                CustomerCategory.Gold => new GoldCustomerDiscountStrategy(),
                _ => new NewCustomerDiscountStrategy()
            }; 
        }

    }
}
