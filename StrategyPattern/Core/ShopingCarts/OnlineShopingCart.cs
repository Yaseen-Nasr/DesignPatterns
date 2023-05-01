using StrategyPattern.Core;

namespace SalesPattern.Core.ShopingCarts
{
    internal class OnlineShopingCart : ShopingCart
    {
        protected override void ApplyDiscount(Invoice invoice)
        {
            if (invoice.TotalPrice >= 10000) invoice.DiscountPrecentage = 0.05;
        }
    }
}
